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
    /// School
    /// </summary>
    [DataContract]
    public partial class School :  IEquatable<School>, IValidatableObject
    {
        /// <summary>
        /// Defines HighGrade
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum HighGradeEnum
        {
            
            /// <summary>
            /// Enum InfantToddler for value: InfantToddler
            /// </summary>
            [EnumMember(Value = "InfantToddler")]
            InfantToddler = 1,
            
            /// <summary>
            /// Enum Preschool for value: Preschool
            /// </summary>
            [EnumMember(Value = "Preschool")]
            Preschool = 2,
            
            /// <summary>
            /// Enum PreKindergarten for value: PreKindergarten
            /// </summary>
            [EnumMember(Value = "PreKindergarten")]
            PreKindergarten = 3,
            
            /// <summary>
            /// Enum TransitionalKindergarten for value: TransitionalKindergarten
            /// </summary>
            [EnumMember(Value = "TransitionalKindergarten")]
            TransitionalKindergarten = 4,
            
            /// <summary>
            /// Enum Kindergarten for value: Kindergarten
            /// </summary>
            [EnumMember(Value = "Kindergarten")]
            Kindergarten = 5,
            
            /// <summary>
            /// Enum _1 for value: 1
            /// </summary>
            [EnumMember(Value = "1")]
            _1 = 6,
            
            /// <summary>
            /// Enum _2 for value: 2
            /// </summary>
            [EnumMember(Value = "2")]
            _2 = 7,
            
            /// <summary>
            /// Enum _3 for value: 3
            /// </summary>
            [EnumMember(Value = "3")]
            _3 = 8,
            
            /// <summary>
            /// Enum _4 for value: 4
            /// </summary>
            [EnumMember(Value = "4")]
            _4 = 9,
            
            /// <summary>
            /// Enum _5 for value: 5
            /// </summary>
            [EnumMember(Value = "5")]
            _5 = 10,
            
            /// <summary>
            /// Enum _6 for value: 6
            /// </summary>
            [EnumMember(Value = "6")]
            _6 = 11,
            
            /// <summary>
            /// Enum _7 for value: 7
            /// </summary>
            [EnumMember(Value = "7")]
            _7 = 12,
            
            /// <summary>
            /// Enum _8 for value: 8
            /// </summary>
            [EnumMember(Value = "8")]
            _8 = 13,
            
            /// <summary>
            /// Enum _9 for value: 9
            /// </summary>
            [EnumMember(Value = "9")]
            _9 = 14,
            
            /// <summary>
            /// Enum _10 for value: 10
            /// </summary>
            [EnumMember(Value = "10")]
            _10 = 15,
            
            /// <summary>
            /// Enum _11 for value: 11
            /// </summary>
            [EnumMember(Value = "11")]
            _11 = 16,
            
            /// <summary>
            /// Enum _12 for value: 12
            /// </summary>
            [EnumMember(Value = "12")]
            _12 = 17,
            
            /// <summary>
            /// Enum _13 for value: 13
            /// </summary>
            [EnumMember(Value = "13")]
            _13 = 18,
            
            /// <summary>
            /// Enum PostGraduate for value: PostGraduate
            /// </summary>
            [EnumMember(Value = "PostGraduate")]
            PostGraduate = 19,
            
            /// <summary>
            /// Enum Ungraded for value: Ungraded
            /// </summary>
            [EnumMember(Value = "Ungraded")]
            Ungraded = 20,
            
            /// <summary>
            /// Enum Other for value: Other
            /// </summary>
            [EnumMember(Value = "Other")]
            Other = 21,
            
            /// <summary>
            /// Enum Empty for value: 
            /// </summary>
            [EnumMember(Value = "")]
            Empty = 22
        }

        /// <summary>
        /// Gets or Sets HighGrade
        /// </summary>
        [DataMember(Name="high_grade", EmitDefaultValue=false)]
        public HighGradeEnum? HighGrade { get; set; }
        /// <summary>
        /// Defines LowGrade
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum LowGradeEnum
        {
            
            /// <summary>
            /// Enum InfantToddler for value: InfantToddler
            /// </summary>
            [EnumMember(Value = "InfantToddler")]
            InfantToddler = 1,
            
            /// <summary>
            /// Enum Preschool for value: Preschool
            /// </summary>
            [EnumMember(Value = "Preschool")]
            Preschool = 2,
            
            /// <summary>
            /// Enum PreKindergarten for value: PreKindergarten
            /// </summary>
            [EnumMember(Value = "PreKindergarten")]
            PreKindergarten = 3,
            
            /// <summary>
            /// Enum TransitionalKindergarten for value: TransitionalKindergarten
            /// </summary>
            [EnumMember(Value = "TransitionalKindergarten")]
            TransitionalKindergarten = 4,
            
            /// <summary>
            /// Enum Kindergarten for value: Kindergarten
            /// </summary>
            [EnumMember(Value = "Kindergarten")]
            Kindergarten = 5,
            
            /// <summary>
            /// Enum _1 for value: 1
            /// </summary>
            [EnumMember(Value = "1")]
            _1 = 6,
            
            /// <summary>
            /// Enum _2 for value: 2
            /// </summary>
            [EnumMember(Value = "2")]
            _2 = 7,
            
            /// <summary>
            /// Enum _3 for value: 3
            /// </summary>
            [EnumMember(Value = "3")]
            _3 = 8,
            
            /// <summary>
            /// Enum _4 for value: 4
            /// </summary>
            [EnumMember(Value = "4")]
            _4 = 9,
            
            /// <summary>
            /// Enum _5 for value: 5
            /// </summary>
            [EnumMember(Value = "5")]
            _5 = 10,
            
            /// <summary>
            /// Enum _6 for value: 6
            /// </summary>
            [EnumMember(Value = "6")]
            _6 = 11,
            
            /// <summary>
            /// Enum _7 for value: 7
            /// </summary>
            [EnumMember(Value = "7")]
            _7 = 12,
            
            /// <summary>
            /// Enum _8 for value: 8
            /// </summary>
            [EnumMember(Value = "8")]
            _8 = 13,
            
            /// <summary>
            /// Enum _9 for value: 9
            /// </summary>
            [EnumMember(Value = "9")]
            _9 = 14,
            
            /// <summary>
            /// Enum _10 for value: 10
            /// </summary>
            [EnumMember(Value = "10")]
            _10 = 15,
            
            /// <summary>
            /// Enum _11 for value: 11
            /// </summary>
            [EnumMember(Value = "11")]
            _11 = 16,
            
            /// <summary>
            /// Enum _12 for value: 12
            /// </summary>
            [EnumMember(Value = "12")]
            _12 = 17,
            
            /// <summary>
            /// Enum _13 for value: 13
            /// </summary>
            [EnumMember(Value = "13")]
            _13 = 18,
            
            /// <summary>
            /// Enum PostGraduate for value: PostGraduate
            /// </summary>
            [EnumMember(Value = "PostGraduate")]
            PostGraduate = 19,
            
            /// <summary>
            /// Enum Ungraded for value: Ungraded
            /// </summary>
            [EnumMember(Value = "Ungraded")]
            Ungraded = 20,
            
            /// <summary>
            /// Enum Other for value: Other
            /// </summary>
            [EnumMember(Value = "Other")]
            Other = 21,
            
            /// <summary>
            /// Enum Empty for value: 
            /// </summary>
            [EnumMember(Value = "")]
            Empty = 22
        }

        /// <summary>
        /// Gets or Sets LowGrade
        /// </summary>
        [DataMember(Name="low_grade", EmitDefaultValue=false)]
        public LowGradeEnum? LowGrade { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="School" /> class.
        /// </summary>
        /// <param name="created">created.</param>
        /// <param name="district">district.</param>
        /// <param name="ext">ext.</param>
        /// <param name="highGrade">highGrade.</param>
        /// <param name="id">id.</param>
        /// <param name="lastModified">lastModified.</param>
        /// <param name="location">location.</param>
        /// <param name="lowGrade">lowGrade.</param>
        /// <param name="mdrNumber">mdrNumber.</param>
        /// <param name="name">name.</param>
        /// <param name="ncesId">ncesId.</param>
        /// <param name="phone">phone.</param>
        /// <param name="principal">principal.</param>
        /// <param name="schoolNumber">schoolNumber.</param>
        /// <param name="sisId">sisId.</param>
        /// <param name="stateId">stateId.</param>
        public School(string created = default(string), string district = default(string), Object ext = default(Object), HighGradeEnum? highGrade = default(HighGradeEnum?), string id = default(string), string lastModified = default(string), Location location = default(Location), LowGradeEnum? lowGrade = default(LowGradeEnum?), string mdrNumber = default(string), string name = default(string), string ncesId = default(string), string phone = default(string), Principal principal = default(Principal), string schoolNumber = default(string), string sisId = default(string), string stateId = default(string))
        {
            this.Created = created;
            this.District = district;
            this.Ext = ext;
            this.HighGrade = highGrade;
            this.Id = id;
            this.LastModified = lastModified;
            this.Location = location;
            this.LowGrade = lowGrade;
            this.MdrNumber = mdrNumber;
            this.Name = name;
            this.NcesId = ncesId;
            this.Phone = phone;
            this.Principal = principal;
            this.SchoolNumber = schoolNumber;
            this.SisId = sisId;
            this.StateId = stateId;
        }
        
        /// <summary>
        /// Gets or Sets Created
        /// </summary>
        [DataMember(Name="created", EmitDefaultValue=false)]
        public string Created { get; set; }

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
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets LastModified
        /// </summary>
        [DataMember(Name="last_modified", EmitDefaultValue=false)]
        public string LastModified { get; set; }

        /// <summary>
        /// Gets or Sets Location
        /// </summary>
        [DataMember(Name="location", EmitDefaultValue=false)]
        public Location Location { get; set; }


        /// <summary>
        /// Gets or Sets MdrNumber
        /// </summary>
        [DataMember(Name="mdr_number", EmitDefaultValue=false)]
        public string MdrNumber { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets NcesId
        /// </summary>
        [DataMember(Name="nces_id", EmitDefaultValue=false)]
        public string NcesId { get; set; }

        /// <summary>
        /// Gets or Sets Phone
        /// </summary>
        [DataMember(Name="phone", EmitDefaultValue=false)]
        public string Phone { get; set; }

        /// <summary>
        /// Gets or Sets Principal
        /// </summary>
        [DataMember(Name="principal", EmitDefaultValue=false)]
        public Principal Principal { get; set; }

        /// <summary>
        /// Gets or Sets SchoolNumber
        /// </summary>
        [DataMember(Name="school_number", EmitDefaultValue=false)]
        public string SchoolNumber { get; set; }

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
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class School {\n");
            sb.Append("  Created: ").Append(Created).Append("\n");
            sb.Append("  District: ").Append(District).Append("\n");
            sb.Append("  Ext: ").Append(Ext).Append("\n");
            sb.Append("  HighGrade: ").Append(HighGrade).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  LastModified: ").Append(LastModified).Append("\n");
            sb.Append("  Location: ").Append(Location).Append("\n");
            sb.Append("  LowGrade: ").Append(LowGrade).Append("\n");
            sb.Append("  MdrNumber: ").Append(MdrNumber).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  NcesId: ").Append(NcesId).Append("\n");
            sb.Append("  Phone: ").Append(Phone).Append("\n");
            sb.Append("  Principal: ").Append(Principal).Append("\n");
            sb.Append("  SchoolNumber: ").Append(SchoolNumber).Append("\n");
            sb.Append("  SisId: ").Append(SisId).Append("\n");
            sb.Append("  StateId: ").Append(StateId).Append("\n");
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
            return this.Equals(input as School);
        }

        /// <summary>
        /// Returns true if School instances are equal
        /// </summary>
        /// <param name="input">Instance of School to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(School input)
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
                    this.HighGrade == input.HighGrade ||
                    (this.HighGrade != null &&
                    this.HighGrade.Equals(input.HighGrade))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.LastModified == input.LastModified ||
                    (this.LastModified != null &&
                    this.LastModified.Equals(input.LastModified))
                ) && 
                (
                    this.Location == input.Location ||
                    (this.Location != null &&
                    this.Location.Equals(input.Location))
                ) && 
                (
                    this.LowGrade == input.LowGrade ||
                    (this.LowGrade != null &&
                    this.LowGrade.Equals(input.LowGrade))
                ) && 
                (
                    this.MdrNumber == input.MdrNumber ||
                    (this.MdrNumber != null &&
                    this.MdrNumber.Equals(input.MdrNumber))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.NcesId == input.NcesId ||
                    (this.NcesId != null &&
                    this.NcesId.Equals(input.NcesId))
                ) && 
                (
                    this.Phone == input.Phone ||
                    (this.Phone != null &&
                    this.Phone.Equals(input.Phone))
                ) && 
                (
                    this.Principal == input.Principal ||
                    (this.Principal != null &&
                    this.Principal.Equals(input.Principal))
                ) && 
                (
                    this.SchoolNumber == input.SchoolNumber ||
                    (this.SchoolNumber != null &&
                    this.SchoolNumber.Equals(input.SchoolNumber))
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
                if (this.District != null)
                    hashCode = hashCode * 59 + this.District.GetHashCode();
                if (this.Ext != null)
                    hashCode = hashCode * 59 + this.Ext.GetHashCode();
                if (this.HighGrade != null)
                    hashCode = hashCode * 59 + this.HighGrade.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.LastModified != null)
                    hashCode = hashCode * 59 + this.LastModified.GetHashCode();
                if (this.Location != null)
                    hashCode = hashCode * 59 + this.Location.GetHashCode();
                if (this.LowGrade != null)
                    hashCode = hashCode * 59 + this.LowGrade.GetHashCode();
                if (this.MdrNumber != null)
                    hashCode = hashCode * 59 + this.MdrNumber.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.NcesId != null)
                    hashCode = hashCode * 59 + this.NcesId.GetHashCode();
                if (this.Phone != null)
                    hashCode = hashCode * 59 + this.Phone.GetHashCode();
                if (this.Principal != null)
                    hashCode = hashCode * 59 + this.Principal.GetHashCode();
                if (this.SchoolNumber != null)
                    hashCode = hashCode * 59 + this.SchoolNumber.GetHashCode();
                if (this.SisId != null)
                    hashCode = hashCode * 59 + this.SisId.GetHashCode();
                if (this.StateId != null)
                    hashCode = hashCode * 59 + this.StateId.GetHashCode();
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