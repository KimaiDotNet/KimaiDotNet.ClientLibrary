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

    public partial class TagEditForm
    {
        /// <summary>
        /// Initializes a new instance of the TagEditForm class.
        /// </summary>
        public TagEditForm()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the TagEditForm class.
        /// </summary>
        /// <param name="name">The tag name (forbidden character:
        /// comma)</param>
        /// <param name="color">The hexadecimal color code (default:
        /// #d2d6de)</param>
        public TagEditForm(string name, string color)
        {
            Name = name;
            Color = color;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the tag name (forbidden character: comma)
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the hexadecimal color code (default: #d2d6de)
        /// </summary>
        [JsonProperty(PropertyName = "color")]
        public string Color { get; set; }

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
            if (Color == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Color");
            }
        }
    }
}
