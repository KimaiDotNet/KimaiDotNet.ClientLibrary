// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace MarkZither.KimaiDotNet.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class ActivityRateForm
    {
        /// <summary>
        /// Initializes a new instance of the ActivityRateForm class.
        /// </summary>
        public ActivityRateForm()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ActivityRateForm class.
        /// </summary>
        /// <param name="rate">The rate (eg. 10.5)</param>
        /// <param name="user">User ID</param>
        /// <param name="internalRate">The internal rate (eg. 10.0 or
        /// 10)</param>
        /// <param name="isFixed">If "true" each time record gets the same
        /// rate, regardless of its duration</param>
        public ActivityRateForm(double rate, int? user = default(int?), double? internalRate = default(double?), bool? isFixed = default(bool?))
        {
            User = user;
            Rate = rate;
            InternalRate = internalRate;
            IsFixed = isFixed;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets user ID
        /// </summary>
        [JsonProperty(PropertyName = "user")]
        public int? User { get; set; }

        /// <summary>
        /// Gets or sets the rate (eg. 10.5)
        /// </summary>
        [JsonProperty(PropertyName = "rate")]
        public double Rate { get; set; }

        /// <summary>
        /// Gets or sets the internal rate (eg. 10.0 or 10)
        /// </summary>
        [JsonProperty(PropertyName = "internalRate")]
        public double? InternalRate { get; set; }

        /// <summary>
        /// Gets or sets if "true" each time record gets the same rate,
        /// regardless of its duration
        /// </summary>
        [JsonProperty(PropertyName = "isFixed")]
        public bool? IsFixed { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            //Nothing to validate
        }
    }
}
