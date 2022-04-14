# Clever - the C# library for the Clever API

The Clever API

This C# SDK is automatically generated by the [Swagger Codegen](https://github.com/swagger-api/swagger-codegen) project:

- API version: 3.0.0
- SDK version: 1.0.0
- Build package: io.swagger.codegen.languages.CSharpClientCodegen

<a name="frameworks-supported"></a>
## Frameworks supported
- .NET 4.0 or later
- Windows Phone 7.1 (Mango)

<a name="dependencies"></a>
## Dependencies
- [RestSharp](https://www.nuget.org/packages/RestSharp) - 105.1.0 or later
- [Json.NET](https://www.nuget.org/packages/Newtonsoft.Json/) - 7.0.0 or later
- [JsonSubTypes](https://www.nuget.org/packages/JsonSubTypes/) - 1.2.0 or later

The DLLs included in the package may not be the latest version. We recommend using [NuGet](https://docs.nuget.org/consume/installing-nuget) to obtain the latest version of the packages:
```
Install-Package RestSharp
Install-Package Newtonsoft.Json
Install-Package JsonSubTypes
```

NOTE: RestSharp versions greater than 105.1.0 have a bug which causes file uploads to fail. See [RestSharp#742](https://github.com/restsharp/RestSharp/issues/742)

<a name="installation"></a>
## Installation
Run the following command to generate the DLL
- [Mac/Linux] `/bin/sh build.sh`
- [Windows] `build.bat`

Then include the DLL (under the `bin` folder) in the C# project, and use the namespaces:
```csharp
using Clever.Api;
using Clever.Client;
using Clever.Model;
```
<a name="packaging"></a>
## Packaging

A `.nuspec` is included with the project. You can follow the Nuget quickstart to [create](https://docs.microsoft.com/en-us/nuget/quickstart/create-and-publish-a-package#create-the-package) and [publish](https://docs.microsoft.com/en-us/nuget/quickstart/create-and-publish-a-package#publish-the-package) packages.

This `.nuspec` uses placeholders from the `.csproj`, so build the `.csproj` directly:

```
nuget pack -Build -OutputDirectory out Clever.csproj
```

Then, publish to a [local feed](https://docs.microsoft.com/en-us/nuget/hosting-packages/local-feeds) or [other host](https://docs.microsoft.com/en-us/nuget/hosting-packages/overview) and consume the new package via Nuget as usual.

<a name="getting-started"></a>
## Getting Started

```csharp
using System;
using System.Diagnostics;
using Clever.Api;
using Clever.Client;
using Clever.Model;

namespace Example
{
    public class Example
    {
        public void main()
        {

            // Configure OAuth2 access token for authorization: oauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DataApi();
            var id = id_example;  // string | 
            var limit = 56;  // int? |  (optional) 
            var startingAfter = startingAfter_example;  // string |  (optional) 
            var endingBefore = endingBefore_example;  // string |  (optional) 

            try
            {
                UsersResponse result = apiInstance.GetContactsForUser(id, limit, startingAfter, endingBefore);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DataApi.GetContactsForUser: " + e.Message );
            }

        }
    }
}
```

<a name="documentation-for-api-endpoints"></a>
## Documentation for API Endpoints

All URIs are relative to *https://api.clever.com/v3.0*

Class | Method | HTTP request | Description
------------ | ------------- | ------------- | -------------
*DataApi* | [**GetContactsForUser**](docs/DataApi.md#getcontactsforuser) | **GET** /users/{id}/mycontacts | 
*DataApi* | [**GetCourse**](docs/DataApi.md#getcourse) | **GET** /courses/{id} | 
*DataApi* | [**GetCourseForSection**](docs/DataApi.md#getcourseforsection) | **GET** /sections/{id}/course | 
*DataApi* | [**GetCourses**](docs/DataApi.md#getcourses) | **GET** /courses | 
*DataApi* | [**GetCoursesForResource**](docs/DataApi.md#getcoursesforresource) | **GET** /resources/{id}/courses | 
*DataApi* | [**GetCoursesForSchool**](docs/DataApi.md#getcoursesforschool) | **GET** /schools/{id}/courses | 
*DataApi* | [**GetDistrict**](docs/DataApi.md#getdistrict) | **GET** /districts/{id} | 
*DataApi* | [**GetDistrictForCourse**](docs/DataApi.md#getdistrictforcourse) | **GET** /courses/{id}/district | 
*DataApi* | [**GetDistrictForSchool**](docs/DataApi.md#getdistrictforschool) | **GET** /schools/{id}/district | 
*DataApi* | [**GetDistrictForSection**](docs/DataApi.md#getdistrictforsection) | **GET** /sections/{id}/district | 
*DataApi* | [**GetDistrictForTerm**](docs/DataApi.md#getdistrictforterm) | **GET** /terms/{id}/district | 
*DataApi* | [**GetDistrictForUser**](docs/DataApi.md#getdistrictforuser) | **GET** /users/{id}/district | 
*DataApi* | [**GetDistricts**](docs/DataApi.md#getdistricts) | **GET** /districts | 
*DataApi* | [**GetResource**](docs/DataApi.md#getresource) | **GET** /resources/{id} | 
*DataApi* | [**GetResources**](docs/DataApi.md#getresources) | **GET** /resources | 
*DataApi* | [**GetResourcesForCourse**](docs/DataApi.md#getresourcesforcourse) | **GET** /courses/{id}/resources | 
*DataApi* | [**GetResourcesForSection**](docs/DataApi.md#getresourcesforsection) | **GET** /sections/{id}/resources | 
*DataApi* | [**GetResourcesForUser**](docs/DataApi.md#getresourcesforuser) | **GET** /users/{id}/resources | 
*DataApi* | [**GetSchool**](docs/DataApi.md#getschool) | **GET** /schools/{id} | 
*DataApi* | [**GetSchoolForSection**](docs/DataApi.md#getschoolforsection) | **GET** /sections/{id}/school | 
*DataApi* | [**GetSchools**](docs/DataApi.md#getschools) | **GET** /schools | 
*DataApi* | [**GetSchoolsForCourse**](docs/DataApi.md#getschoolsforcourse) | **GET** /courses/{id}/schools | 
*DataApi* | [**GetSchoolsForTerm**](docs/DataApi.md#getschoolsforterm) | **GET** /terms/{id}/schools | 
*DataApi* | [**GetSchoolsForUser**](docs/DataApi.md#getschoolsforuser) | **GET** /users/{id}/schools | 
*DataApi* | [**GetSection**](docs/DataApi.md#getsection) | **GET** /sections/{id} | 
*DataApi* | [**GetSections**](docs/DataApi.md#getsections) | **GET** /sections | 
*DataApi* | [**GetSectionsForCourse**](docs/DataApi.md#getsectionsforcourse) | **GET** /courses/{id}/sections | 
*DataApi* | [**GetSectionsForResource**](docs/DataApi.md#getsectionsforresource) | **GET** /resources/{id}/sections | 
*DataApi* | [**GetSectionsForSchool**](docs/DataApi.md#getsectionsforschool) | **GET** /schools/{id}/sections | 
*DataApi* | [**GetSectionsForTerm**](docs/DataApi.md#getsectionsforterm) | **GET** /terms/{id}/sections | 
*DataApi* | [**GetSectionsForUser**](docs/DataApi.md#getsectionsforuser) | **GET** /users/{id}/sections | 
*DataApi* | [**GetStudentsForUser**](docs/DataApi.md#getstudentsforuser) | **GET** /users/{id}/mystudents | 
*DataApi* | [**GetTeachersForUser**](docs/DataApi.md#getteachersforuser) | **GET** /users/{id}/myteachers | 
*DataApi* | [**GetTerm**](docs/DataApi.md#getterm) | **GET** /terms/{id} | 
*DataApi* | [**GetTermForSection**](docs/DataApi.md#gettermforsection) | **GET** /sections/{id}/term | 
*DataApi* | [**GetTerms**](docs/DataApi.md#getterms) | **GET** /terms | 
*DataApi* | [**GetTermsForSchool**](docs/DataApi.md#gettermsforschool) | **GET** /schools/{id}/terms | 
*DataApi* | [**GetUser**](docs/DataApi.md#getuser) | **GET** /users/{id} | 
*DataApi* | [**GetUsers**](docs/DataApi.md#getusers) | **GET** /users | 
*DataApi* | [**GetUsersForResource**](docs/DataApi.md#getusersforresource) | **GET** /resources/{id}/users | 
*DataApi* | [**GetUsersForSchool**](docs/DataApi.md#getusersforschool) | **GET** /schools/{id}/users | 
*DataApi* | [**GetUsersForSection**](docs/DataApi.md#getusersforsection) | **GET** /sections/{id}/users | 
*EventsApi* | [**GetEvent**](docs/EventsApi.md#getevent) | **GET** /events/{id} | 
*EventsApi* | [**GetEvents**](docs/EventsApi.md#getevents) | **GET** /events | 


<a name="documentation-for-models"></a>
## Documentation for Models

 - [Model.BadRequest](docs/BadRequest.md)
 - [Model.Contact](docs/Contact.md)
 - [Model.Course](docs/Course.md)
 - [Model.CourseObject](docs/CourseObject.md)
 - [Model.CourseResponse](docs/CourseResponse.md)
 - [Model.CoursesCreated](docs/CoursesCreated.md)
 - [Model.CoursesDeleted](docs/CoursesDeleted.md)
 - [Model.CoursesResponse](docs/CoursesResponse.md)
 - [Model.CoursesUpdated](docs/CoursesUpdated.md)
 - [Model.Credentials](docs/Credentials.md)
 - [Model.District](docs/District.md)
 - [Model.DistrictAdmin](docs/DistrictAdmin.md)
 - [Model.DistrictContact](docs/DistrictContact.md)
 - [Model.DistrictObject](docs/DistrictObject.md)
 - [Model.DistrictResponse](docs/DistrictResponse.md)
 - [Model.DistrictsCreated](docs/DistrictsCreated.md)
 - [Model.DistrictsDeleted](docs/DistrictsDeleted.md)
 - [Model.DistrictsResponse](docs/DistrictsResponse.md)
 - [Model.DistrictsUpdated](docs/DistrictsUpdated.md)
 - [Model.Event](docs/Event.md)
 - [Model.EventResponse](docs/EventResponse.md)
 - [Model.EventsResponse](docs/EventsResponse.md)
 - [Model.InternalError](docs/InternalError.md)
 - [Model.Link](docs/Link.md)
 - [Model.Location](docs/Location.md)
 - [Model.Name](docs/Name.md)
 - [Model.NotFound](docs/NotFound.md)
 - [Model.Principal](docs/Principal.md)
 - [Model.Resource](docs/Resource.md)
 - [Model.ResourceObject](docs/ResourceObject.md)
 - [Model.ResourceResponse](docs/ResourceResponse.md)
 - [Model.ResourcesCreated](docs/ResourcesCreated.md)
 - [Model.ResourcesDeleted](docs/ResourcesDeleted.md)
 - [Model.ResourcesResponse](docs/ResourcesResponse.md)
 - [Model.ResourcesUpdated](docs/ResourcesUpdated.md)
 - [Model.Roles](docs/Roles.md)
 - [Model.School](docs/School.md)
 - [Model.SchoolEnrollment](docs/SchoolEnrollment.md)
 - [Model.SchoolObject](docs/SchoolObject.md)
 - [Model.SchoolResponse](docs/SchoolResponse.md)
 - [Model.SchoolsCreated](docs/SchoolsCreated.md)
 - [Model.SchoolsDeleted](docs/SchoolsDeleted.md)
 - [Model.SchoolsResponse](docs/SchoolsResponse.md)
 - [Model.SchoolsUpdated](docs/SchoolsUpdated.md)
 - [Model.Section](docs/Section.md)
 - [Model.SectionObject](docs/SectionObject.md)
 - [Model.SectionResponse](docs/SectionResponse.md)
 - [Model.SectionsCreated](docs/SectionsCreated.md)
 - [Model.SectionsDeleted](docs/SectionsDeleted.md)
 - [Model.SectionsResponse](docs/SectionsResponse.md)
 - [Model.SectionsUpdated](docs/SectionsUpdated.md)
 - [Model.Staff](docs/Staff.md)
 - [Model.Student](docs/Student.md)
 - [Model.StudentRelationship](docs/StudentRelationship.md)
 - [Model.Teacher](docs/Teacher.md)
 - [Model.Term](docs/Term.md)
 - [Model.TermObject](docs/TermObject.md)
 - [Model.TermResponse](docs/TermResponse.md)
 - [Model.TermsCreated](docs/TermsCreated.md)
 - [Model.TermsDeleted](docs/TermsDeleted.md)
 - [Model.TermsResponse](docs/TermsResponse.md)
 - [Model.TermsUpdated](docs/TermsUpdated.md)
 - [Model.User](docs/User.md)
 - [Model.UserObject](docs/UserObject.md)
 - [Model.UserResponse](docs/UserResponse.md)
 - [Model.UsersCreated](docs/UsersCreated.md)
 - [Model.UsersDeleted](docs/UsersDeleted.md)
 - [Model.UsersResponse](docs/UsersResponse.md)
 - [Model.UsersUpdated](docs/UsersUpdated.md)


<a name="documentation-for-authorization"></a>
## Documentation for Authorization

<a name="oauth"></a>
### oauth

- **Type**: OAuth
- **Flow**: accessCode
- **Authorization URL**: https://clever.com/oauth/authorize
- **Scopes**: N/A

