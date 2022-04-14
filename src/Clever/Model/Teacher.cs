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
    /// Teacher
    /// </summary>
    [DataContract]
    public partial class Teacher :  IEquatable<Teacher>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Teacher" /> class.
        /// </summary>
        /// <param name="created">created.</param>
        /// <param name="credentials">credentials.</param>
        /// <param name="district">district.</param>
        /// <param name="ext">ext.</param>
        /// <param name="lastModified">lastModified.</param>
        /// <param name="legacyId">legacyId.</param>
        /// <param name="name">name.</param>
        /// <param name="school">school.</param>
        /// <param name="schools">schools.</param>
        /// <param name="sisId">sisId.</param>
        /// <param name="stateId">stateId.</param>
        /// <param name="teacherNumber">teacherNumber.</param>
        /// <param name="title">title.</param>
        public Teacher(string created = default(string), Credentials credentials = default(Credentials), string district = default(string), Object ext = default(Object), string lastModified = default(string), string legacyId = default(string), Name name = default(Name), string school = default(string), List<string> schools = default(List<string>), string sisId = default(string), string stateId = default(string), string teacherNumber = default(string), string title = default(string))
        {
            this.Created = created;
            this.Credentials = credentials;
            this.District = district;
            this.Ext = ext;
            this.LastModified = lastModified;
            this.LegacyId = legacyId;
            this.Name = name;
            this.School = school;
            this.Schools = schools;
            this.SisId = sisId;
            this.StateId = stateId;
            this.TeacherNumber = teacherNumber;
            this.Title = title;
        }
        
        /// <summary>
        /// Gets or Sets Created
        /// </summary>
        [DataMember(Name="created", EmitDefaultValue=false)]
        public string Created { get; set; }

        /// <summary>
        /// Gets or Sets Credentials
        /// </summary>
        [DataMember(Name="credentials", EmitDefaultValue=false)]
        public Credentials Credentials { get; set; }

        /// <summary>
        /// Gets or Sets District
        /// </summary>
        [DataMember(Name="district", EmitDefaultValue=false)]
        public string District { get; set; }

        /// <summary>
        /// Gets or Sets Ext
        /// </summary>
        [DataMember(Name="ext", EmitDefaultValue=false)]
        public Object Ext { get; set; }

        /// <summary>
        /// Gets or Sets LastModified
        /// </summary>
        [DataMember(Name="last_modified", EmitDefaultValue=false)]
        public string LastModified { get; set; }

        /// <summary>
        /// Gets or Sets LegacyId
        /// </summary>
        [DataMember(Name="legacy_id", EmitDefaultValue=false)]
        public string LegacyId { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public Name Name { get; set; }

        /// <summary>
        /// Gets or Sets School
        /// </summary>
        [DataMember(Name="school", EmitDefaultValue=false)]
        public string School { get; set; }

        /// <summary>
        /// Gets or Sets Schools
        /// </summary>
        [DataMember(Name="schools", EmitDefaultValue=false)]
        public List<string> Schools { get; set; }

        /// <summary>
        /// Gets or Sets SisId
        /// </summary>
        [DataMember(Name="sis_id", EmitDefaultValue=false)]
        public string SisId { get; set; }

        /// <summary>
        /// Gets or Sets StateId
        /// </summary>
        [DataMember(Name="state_id", EmitDefaultValue=false)]
        public string StateId { get; set; }

        /// <summary>
        /// Gets or Sets TeacherNumber
        /// </summary>
        [DataMember(Name="teacher_number", EmitDefaultValue=false)]
        public string TeacherNumber { get; set; }

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
            sb.Append("class Teacher {\n");
            sb.Append("  Created: ").Append(Created).Append("\n");
            sb.Append("  Credentials: ").Append(Credentials).Append("\n");
            sb.Append("  District: ").Append(District).Append("\n");
            sb.Append("  Ext: ").Append(Ext).Append("\n");
            sb.Append("  LastModified: ").Append(LastModified).Append("\n");
            sb.Append("  LegacyId: ").Append(LegacyId).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  School: ").Append(School).Append("\n");
            sb.Append("  Schools: ").Append(Schools).Append("\n");
            sb.Append("  SisId: ").Append(SisId).Append("\n");
            sb.Append("  StateId: ").Append(StateId).Append("\n");
            sb.Append("  TeacherNumber: ").Append(TeacherNumber).Append("\n");
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
            return this.Equals(input as Teacher);
        }

        /// <summary>
        /// Returns true if Teacher instances are equal
        /// </summary>
        /// <param name="input">Instance of Teacher to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Teacher input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Created == input.Created ||
                    (this.Created != null &&
                    this.Created.Equals(input.Created))
                ) && 
                (
                    this.Credentials == input.Credentials ||
                    (this.Credentials != null &&
                    this.Credentials.Equals(input.Credentials))
                ) && 
                (
                    this.District == input.District ||
                    (this.District != null &&
                    this.District.Equals(input.District))
                ) && 
                (
                    this.Ext == input.Ext ||
                    (this.Ext != null &&
                    this.Ext.Equals(input.Ext))
                ) && 
                (
                    this.LastModified == input.LastModified ||
                    (this.LastModified != null &&
                    this.LastModified.Equals(input.LastModified))
                ) && 
                (
                    this.LegacyId == input.LegacyId ||
                    (this.LegacyId != null &&
                    this.LegacyId.Equals(input.LegacyId))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.School == input.School ||
                    (this.School != null &&
                    this.School.Equals(input.School))
                ) && 
                (
                    this.Schools == input.Schools ||
                    this.Schools != null &&
                    this.Schools.SequenceEqual(input.Schools)
                ) && 
                (
                    this.SisId == input.SisId ||
                    (this.SisId != null &&
                    this.SisId.Equals(input.SisId))
                ) && 
                (
                    this.StateId == input.StateId ||
                    (this.StateId != null &&
                    this.StateId.Equals(input.StateId))
                ) && 
                (
                    this.TeacherNumber == input.TeacherNumber ||
                    (this.TeacherNumber != null &&
                    this.TeacherNumber.Equals(input.TeacherNumber))
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
                if (this.Created != null)
                    hashCode = hashCode * 59 + this.Created.GetHashCode();
                if (this.Credentials != null)
                    hashCode = hashCode * 59 + this.Credentials.GetHashCode();
                if (this.District != null)
                    hashCode = hashCode * 59 + this.District.GetHashCode();
                if (this.Ext != null)
                    hashCode = hashCode * 59 + this.Ext.GetHashCode();
                if (this.LastModified != null)
                    hashCode = hashCode * 59 + this.LastModified.GetHashCode();
                if (this.LegacyId != null)
                    hashCode = hashCode * 59 + this.LegacyId.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.School != null)
                    hashCode = hashCode * 59 + this.School.GetHashCode();
                if (this.Schools != null)
                    hashCode = hashCode * 59 + this.Schools.GetHashCode();
                if (this.SisId != null)
                    hashCode = hashCode * 59 + this.SisId.GetHashCode();
                if (this.StateId != null)
                    hashCode = hashCode * 59 + this.StateId.GetHashCode();
                if (this.TeacherNumber != null)
                    hashCode = hashCode * 59 + this.TeacherNumber.GetHashCode();
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
