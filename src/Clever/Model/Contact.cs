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
    /// Contact
    /// </summary>
    [DataContract]
    public partial class Contact :  IEquatable<Contact>, IValidatableObject
    {
        /// <summary>
        /// Defines PhoneType
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum PhoneTypeEnum
        {
            
            /// <summary>
            /// Enum Cell for value: Cell
            /// </summary>
            [EnumMember(Value = "Cell")]
            Cell = 1,
            
            /// <summary>
            /// Enum Home for value: Home
            /// </summary>
            [EnumMember(Value = "Home")]
            Home = 2,
            
            /// <summary>
            /// Enum Work for value: Work
            /// </summary>
            [EnumMember(Value = "Work")]
            Work = 3,
            
            /// <summary>
            /// Enum Other for value: Other
            /// </summary>
            [EnumMember(Value = "Other")]
            Other = 4,
            
            /// <summary>
            /// Enum Empty for value: 
            /// </summary>
            [EnumMember(Value = "")]
            Empty = 5
        }

        /// <summary>
        /// Gets or Sets PhoneType
        /// </summary>
        [DataMember(Name="phone_type", EmitDefaultValue=false)]
        public PhoneTypeEnum? PhoneType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Contact" /> class.
        /// </summary>
        /// <param name="legacyId">legacyId.</param>
        /// <param name="phone">phone.</param>
        /// <param name="phoneType">phoneType.</param>
        /// <param name="sisId">sisId.</param>
        /// <param name="studentRelationships">studentRelationships.</param>
        public Contact(string legacyId = default(string), string phone = default(string), PhoneTypeEnum? phoneType = default(PhoneTypeEnum?), string sisId = default(string), List<StudentRelationship> studentRelationships = default(List<StudentRelationship>))
        {
            this.LegacyId = legacyId;
            this.Phone = phone;
            this.PhoneType = phoneType;
            this.SisId = sisId;
            this.StudentRelationships = studentRelationships;
        }
        
        /// <summary>
        /// Gets or Sets LegacyId
        /// </summary>
        [DataMember(Name="legacy_id", EmitDefaultValue=false)]
        public string LegacyId { get; set; }

        /// <summary>
        /// Gets or Sets Phone
        /// </summary>
        [DataMember(Name="phone", EmitDefaultValue=false)]
        public string Phone { get; set; }


        /// <summary>
        /// Gets or Sets SisId
        /// </summary>
        [DataMember(Name="sis_id", EmitDefaultValue=false)]
        public string SisId { get; set; }

        /// <summary>
        /// Gets or Sets StudentRelationships
        /// </summary>
        [DataMember(Name="student_relationships", EmitDefaultValue=false)]
        public List<StudentRelationship> StudentRelationships { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Contact {\n");
            sb.Append("  LegacyId: ").Append(LegacyId).Append("\n");
            sb.Append("  Phone: ").Append(Phone).Append("\n");
            sb.Append("  PhoneType: ").Append(PhoneType).Append("\n");
            sb.Append("  SisId: ").Append(SisId).Append("\n");
            sb.Append("  StudentRelationships: ").Append(StudentRelationships).Append("\n");
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
            return this.Equals(input as Contact);
        }

        /// <summary>
        /// Returns true if Contact instances are equal
        /// </summary>
        /// <param name="input">Instance of Contact to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Contact input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.LegacyId == input.LegacyId ||
                    (this.LegacyId != null &&
                    this.LegacyId.Equals(input.LegacyId))
                ) && 
                (
                    this.Phone == input.Phone ||
                    (this.Phone != null &&
                    this.Phone.Equals(input.Phone))
                ) && 
                (
                    this.PhoneType == input.PhoneType ||
                    (this.PhoneType != null &&
                    this.PhoneType.Equals(input.PhoneType))
                ) && 
                (
                    this.SisId == input.SisId ||
                    (this.SisId != null &&
                    this.SisId.Equals(input.SisId))
                ) && 
                (
                    this.StudentRelationships == input.StudentRelationships ||
                    this.StudentRelationships != null &&
                    this.StudentRelationships.SequenceEqual(input.StudentRelationships)
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
                if (this.LegacyId != null)
                    hashCode = hashCode * 59 + this.LegacyId.GetHashCode();
                if (this.Phone != null)
                    hashCode = hashCode * 59 + this.Phone.GetHashCode();
                if (this.PhoneType != null)
                    hashCode = hashCode * 59 + this.PhoneType.GetHashCode();
                if (this.SisId != null)
                    hashCode = hashCode * 59 + this.SisId.GetHashCode();
                if (this.StudentRelationships != null)
                    hashCode = hashCode * 59 + this.StudentRelationships.GetHashCode();
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
