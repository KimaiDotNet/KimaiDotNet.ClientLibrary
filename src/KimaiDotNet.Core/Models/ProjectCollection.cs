// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace MarkZither.KimaiDotNet.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    public partial class ProjectCollection
    {
        /// <summary>
        /// Initializes a new instance of the ProjectCollection class.
        /// </summary>
        public ProjectCollection()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ProjectCollection class.
        /// </summary>
        /// <param name="name">Project name</param>
        /// <param name="id">Internal ID</param>
        /// <param name="metaFields">Meta fields</param>
        /// <param name="teams">Teams</param>
        /// <param name="color">The assigned color in HTML hex format, eg.
        /// #dd1d00</param>
        public ProjectCollection(string name, bool visible, string parentTitle = default(string), int? customer = default(int?), int? id = default(int?), System.DateTime? start = default(System.DateTime?), System.DateTime? end = default(System.DateTime?), IList<ProjectMeta> metaFields = default(IList<ProjectMeta>), IList<Team> teams = default(IList<Team>), string color = default(string))
        {
            ParentTitle = parentTitle;
            Customer = customer;
            Id = id;
            Name = name;
            Start = start;
            End = end;
            Visible = visible;
            MetaFields = metaFields;
            Teams = teams;
            Color = color;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "parentTitle")]
        public string ParentTitle { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "customer")]
        public int? Customer { get; set; }

        /// <summary>
        /// Gets or sets internal ID
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public int? Id { get; set; }

        /// <summary>
        /// Gets or sets project name
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "start")]
        public System.DateTime? Start { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "end")]
        public System.DateTime? End { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "visible")]
        public bool Visible { get; set; }

        /// <summary>
        /// Gets or sets meta fields
        /// </summary>
        /// <remarks>
        /// All visible meta (custom) fields registered with this project
        /// </remarks>
        [JsonProperty(PropertyName = "metaFields")]
        public IList<ProjectMeta> MetaFields { get; set; }

        /// <summary>
        /// Gets or sets teams
        /// </summary>
        /// <remarks>
        /// If no team is assigned, everyone can access the project (also
        /// depends on the teams of the customer)
        /// </remarks>
        [JsonProperty(PropertyName = "teams")]
        public IList<Team> Teams { get; set; }

        /// <summary>
        /// Gets or sets the assigned color in HTML hex format, eg. #dd1d00
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
            if (Name != null)
            {
                if (Name.Length > 150)
                {
                    throw new ValidationException(ValidationRules.MaxLength, "Name", 150);
                }
                if (Name.Length < 2)
                {
                    throw new ValidationException(ValidationRules.MinLength, "Name", 2);
                }
            }
            if (MetaFields != null)
            {
                foreach (var element in MetaFields)
                {
                    if (element != null)
                    {
                        element.Validate();
                    }
                }
            }
            if (Teams != null)
            {
                foreach (var element1 in Teams)
                {
                    if (element1 != null)
                    {
                        element1.Validate();
                    }
                }
            }
        }
    }
}
