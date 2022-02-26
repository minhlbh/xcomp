using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Xcomp.Cloud.Core.Attributes.Web
{
    /// <summary>
    /// A <see cref="ValidationAttribute"/> that compares two properties
    /// </summary>
    [AttributeUsage(AttributeTargets.Property, AllowMultiple = false)]
    public sealed class ComparePropertyAttribute : CompareAttribute
    {
        /// <summary>
        /// Initializes a new instance of <see cref="BlazorCompareAttribute"/>.
        /// </summary>
        /// <param name="otherProperty">The property to compare with the current property.</param>
        public ComparePropertyAttribute(string otherProperty)
            : base(otherProperty)
        {
        }

        /// <inheritdoc />
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var validationResult = base.IsValid(value, validationContext);
            if (validationResult == ValidationResult.Success)
            {
                return validationResult;
            }

            return new ValidationResult(validationResult.ErrorMessage, new[] { validationContext.MemberName });
        }
    }
}
