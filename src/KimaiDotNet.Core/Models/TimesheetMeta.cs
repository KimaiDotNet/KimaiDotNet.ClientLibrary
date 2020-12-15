// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace MarkZither.KimaiDotNet.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    public partial class TimesheetMeta
    {
        /// <summary>
        /// Initializes a new instance of the TimesheetMeta class.
        /// </summary>
        public TimesheetMeta()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the TimesheetMeta class.
        /// </summary>
        /// <param name="name">Name of the meta (custom) field</param>
        /// <param name="value">Value of the meta (custom) field</param>
        public TimesheetMeta(string name, string value = default(string))
        {
            Name = name;
            Value = value;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets name of the meta (custom) field
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets value of the meta (custom) field
        /// </summary>
        [JsonProperty(PropertyName = "value")]
        public string Value { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Name == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Name");
            }
            if (Name != null)
            {
                if (Name.Length > 50)
                {
                    throw new ValidationException(ValidationRules.MaxLength, "Name", 50);
                }
                if (Name.Length < 2)
                {
                    throw new ValidationException(ValidationRules.MinLength, "Name", 2);
                }
            }
        }
    }
}
