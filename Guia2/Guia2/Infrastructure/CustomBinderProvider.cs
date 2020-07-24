using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Globalization;
using System.Threading.Tasks;

namespace Guia2.Infrastructure
{
    public class CustomBinderProvider : IModelBinderProvider
    {
        public IModelBinder GetBinder(ModelBinderProviderContext context)
        {
            if (context == null)
            {
                throw new ArgumentNullException(nameof(context));
            }

            if (context.Metadata.ModelType == typeof(decimal))
            {
                return new DecimalModelBinder();
            }

            return null;
        }
    }

    public class DecimalModelBinder : IModelBinder
    {
        public Task BindModelAsync(ModelBindingContext bindingContext)
        {
            var valueProviderResult = bindingContext.ValueProvider.GetValue(bindingContext.ModelName);

            var value = valueProviderResult.FirstValue;

            if (string.IsNullOrEmpty(value))
            {
                return Task.CompletedTask;
            }


            if (!decimal.TryParse(value
                ,NumberStyles.AllowDecimalPoint | NumberStyles.AllowLeadingSign
                ,CultureInfo.InvariantCulture,out var decimalValue))
            {
                // Error
                bindingContext.ModelState.TryAddModelError(
                    bindingContext.ModelName,
                    "Could not parse MyValue.");
                return Task.CompletedTask;
            }

            bindingContext.Result = ModelBindingResult.Success(decimalValue);
            return Task.CompletedTask;
        }
    }
}
