/* 
 * Fax.to REST API client for C#
 *
 * This is Fax.to REST API client for C#.
 *
 * OpenAPI spec version: 2.0.0
 * Contact: inquiries@fax.to
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
using SwaggerDateConverter = IO.Swagger.Client.SwaggerDateConverter;

namespace IO.Swagger.Model
{
    /// <summary>
    /// InlineResponse200
    /// </summary>
    [DataContract]
    public partial class InlineResponse200 :  IEquatable<InlineResponse200>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InlineResponse200" /> class.
        /// </summary>
        /// <param name="status">The status of the API request.</param>
        /// <param name="faxJobId">The id of the fax job. It is used to check the status of the fax job..</param>
        /// <param name="userCashBalance">The remaining cash balance.</param>
        /// <param name="cost">The cost of sending fax.</param>
        public InlineResponse200(string status = default(string), int? faxJobId = default(int?), decimal? userCashBalance = default(decimal?), decimal? cost = default(decimal?))
        {
            this.Status = status;
            this.FaxJobId = faxJobId;
            this.UserCashBalance = userCashBalance;
            this.Cost = cost;
        }
        
        /// <summary>
        /// The status of the API request
        /// </summary>
        /// <value>The status of the API request</value>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public string Status { get; set; }

        /// <summary>
        /// The id of the fax job. It is used to check the status of the fax job.
        /// </summary>
        /// <value>The id of the fax job. It is used to check the status of the fax job.</value>
        [DataMember(Name="fax_job_id", EmitDefaultValue=false)]
        public int? FaxJobId { get; set; }

        /// <summary>
        /// The remaining cash balance
        /// </summary>
        /// <value>The remaining cash balance</value>
        [DataMember(Name="user_cash_balance", EmitDefaultValue=false)]
        public decimal? UserCashBalance { get; set; }

        /// <summary>
        /// The cost of sending fax
        /// </summary>
        /// <value>The cost of sending fax</value>
        [DataMember(Name="cost", EmitDefaultValue=false)]
        public decimal? Cost { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InlineResponse200 {\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  FaxJobId: ").Append(FaxJobId).Append("\n");
            sb.Append("  UserCashBalance: ").Append(UserCashBalance).Append("\n");
            sb.Append("  Cost: ").Append(Cost).Append("\n");
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
            return this.Equals(input as InlineResponse200);
        }

        /// <summary>
        /// Returns true if InlineResponse200 instances are equal
        /// </summary>
        /// <param name="input">Instance of InlineResponse200 to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InlineResponse200 input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.FaxJobId == input.FaxJobId ||
                    (this.FaxJobId != null &&
                    this.FaxJobId.Equals(input.FaxJobId))
                ) && 
                (
                    this.UserCashBalance == input.UserCashBalance ||
                    (this.UserCashBalance != null &&
                    this.UserCashBalance.Equals(input.UserCashBalance))
                ) && 
                (
                    this.Cost == input.Cost ||
                    (this.Cost != null &&
                    this.Cost.Equals(input.Cost))
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
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.FaxJobId != null)
                    hashCode = hashCode * 59 + this.FaxJobId.GetHashCode();
                if (this.UserCashBalance != null)
                    hashCode = hashCode * 59 + this.UserCashBalance.GetHashCode();
                if (this.Cost != null)
                    hashCode = hashCode * 59 + this.Cost.GetHashCode();
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
