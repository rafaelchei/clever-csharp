/* 
 * Clever API
 *
 * The Clever API
 *
 * OpenAPI spec version: 3.0.0
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using SwaggerDateConverter = Clever.Client.SwaggerDateConverter;

namespace Clever.Model
{
    /// <summary>
    /// Staff
    /// </summary>
    [DataContract]
    public partial class Staff :  IEquatable<Staff>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Staff" /> class.
        /// </summary>
        /// <param name="credentials">credentials.</param>
        /// <param name="department">department.</param>
        /// <param name="ext">ext.</param>
        /// <param name="legacyId">legacyId.</param>
        /// <param name="roles">roles.</param>
        /// <param name="schools">schools.</param>
        /// <param name="staffId">staffId.</param>
        /// <param name="title">title.</param>
        public Staff(Credentials credentials = default(Credentials), string department = default(string), Object ext = default(Object), string legacyId = default(string), List<string> roles = default(List<string>), List<string> schools = default(List<string>), string staffId = default(string), string title = default(string))
        {
            this.Credentials = credentials;
            this.Department = department;
            this.Ext = ext;
            this.LegacyId = legacyId;
            this.Roles = roles;
            this.Schools = schools;
            this.StaffId = staffId;
            this.Title = title;
        }
        
        /// <summary>
        /// Gets or Sets Credentials
        /// </summary>
        [DataMember(Name="credentials", EmitDefaultValue=false)]
        public Credentials Credentials { get; set; }

        /// <summary>
        /// Gets or Sets Department
        /// </summary>
        [DataMember(Name="department", EmitDefaultValue=false)]
        public string Department { get; set; }

        /// <summary>
        /// Gets or Sets Ext
        /// </summary>
        [DataMember(Name="ext", EmitDefaultValue=false)]
        public Object Ext { get; set; }

        /// <summary>
        /// Gets or Sets LegacyId
        /// </summary>
        [DataMember(Name="legacy_id", EmitDefaultValue=false)]
        public string LegacyId { get; set; }

        /// <summary>
        /// Gets or Sets Roles
        /// </summary>
        [DataMember(Name="roles", EmitDefaultValue=false)]
        public List<string> Roles { get; set; }

        /// <summary>
        /// Gets or Sets Schools
        /// </summary>
        [DataMember(Name="schools", EmitDefaultValue=false)]
        public List<string> Schools { get; set; }

        /// <summary>
        /// Gets or Sets StaffId
        /// </summary>
        [DataMember(Name="staff_id", EmitDefaultValue=false)]
        public string StaffId { get; set; }

        /// <summary>
        /// Gets or Sets Title
        /// </summary>
        [DataMember(Name="title", EmitDefaultValue=false)]
        public string Title { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Staff {\n");
            sb.Append("  Credentials: ").Append(Credentials).Append("\n");
            sb.Append("  Department: ").Append(Department).Append("\n");
            sb.Append("  Ext: ").Append(Ext).Append("\n");
            sb.Append("  LegacyId: ").Append(LegacyId).Append("\n");
            sb.Append("  Roles: ").Append(Roles).Append("\n");
            sb.Append("  Schools: ").Append(Schools).Append("\n");
            sb.Append("  StaffId: ").Append(StaffId).Append("\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as Staff);
        }

        /// <summary>
        /// Returns true if Staff instances are equal
        /// </summary>
        /// <param name="input">Instance of Staff to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Staff input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Credentials == input.Credentials ||
                    (this.Credentials != null &&
                    this.Credentials.Equals(input.Credentials))
                ) && 
                (
                    this.Department == input.Department ||
                    (this.Department != null &&
                    this.Department.Equals(input.Department))
                ) && 
                (
                    this.Ext == input.Ext ||
                    (this.Ext != null &&
                    this.Ext.Equals(input.Ext))
                ) && 
                (
                    this.LegacyId == input.LegacyId ||
                    (this.LegacyId != null &&
                    this.LegacyId.Equals(input.LegacyId))
                ) && 
                (
                    this.Roles == input.Roles ||
                    this.Roles != null &&
                    this.Roles.SequenceEqual(input.Roles)
                ) && 
                (
                    this.Schools == input.Schools ||
                    this.Schools != null &&
                    this.Schools.SequenceEqual(input.Schools)
                ) && 
                (
                    this.StaffId == input.StaffId ||
                    (this.StaffId != null &&
                    this.StaffId.Equals(input.StaffId))
                ) && 
                (
                    this.Title == input.Title ||
                    (this.Title != null &&
                    this.Title.Equals(input.Title))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.Credentials != null)
                    hashCode = hashCode * 59 + this.Credentials.GetHashCode();
                if (this.Department != null)
                    hashCode = hashCode * 59 + this.Department.GetHashCode();
                if (this.Ext != null)
                    hashCode = hashCode * 59 + this.Ext.GetHashCode();
                if (this.LegacyId != null)
                    hashCode = hashCode * 59 + this.LegacyId.GetHashCode();
                if (this.Roles != null)
                    hashCode = hashCode * 59 + this.Roles.GetHashCode();
                if (this.Schools != null)
                    hashCode = hashCode * 59 + this.Schools.GetHashCode();
                if (this.StaffId != null)
                    hashCode = hashCode * 59 + this.StaffId.GetHashCode();
                if (this.Title != null)
                    hashCode = hashCode * 59 + this.Title.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
