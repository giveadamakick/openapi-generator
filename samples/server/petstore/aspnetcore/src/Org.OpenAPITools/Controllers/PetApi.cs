/*
 * OpenAPI Petstore
 *
 * This is a sample server Petstore server. For this sample, you can use the api key `special-key` to test the authorization filters.
 *
 * The version of the OpenAPI document: 1.0.0
 * 
 * Generated by: https://openapi-generator.tech
 */

using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Swashbuckle.AspNetCore.Annotations;
using Swashbuckle.AspNetCore.SwaggerGen;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using Org.OpenAPITools.Attributes;
using Microsoft.AspNetCore.Authorization;
using Org.OpenAPITools.Models;

namespace Org.OpenAPITools.Controllers
{ 
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    public class PetApiController : ControllerBase
    { 
        /// <summary>
        /// Add a new pet to the store
        /// </summary>
        /// <param name="body">Pet object that needs to be added to the store</param>
        /// <response code="405">Invalid input</response>
        [HttpPost]
        [Route("/v2/pet")]
        [Consumes("application/json", "application/xml")]
        [ValidateModelState]
        [SwaggerOperation("AddPet")]
        public virtual IActionResult AddPet([FromBody]Pet body)
        { 

            //TODO: Uncomment the next line to return response 405 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(405);

            throw new NotImplementedException();
        }

        /// <summary>
        /// Deletes a pet
        /// </summary>
        /// <param name="petId">Pet id to delete</param>
        /// <param name="apiKey"></param>
        /// <response code="400">Invalid pet value</response>
        [HttpDelete]
        [Route("/v2/pet/{petId}")]
        [ValidateModelState]
        [SwaggerOperation("DeletePet")]
        public virtual IActionResult DeletePet([FromRoute (Name = "petId")][Required]long petId, [FromHeader]string apiKey)
        { 

            //TODO: Uncomment the next line to return response 400 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(400);

            throw new NotImplementedException();
        }

        /// <summary>
        /// Finds Pets by status
        /// </summary>
        /// <remarks>Multiple status values can be provided with comma separated strings</remarks>
        /// <param name="status">Status values that need to be considered for filter</param>
        /// <response code="200">successful operation</response>
        /// <response code="400">Invalid status value</response>
        [HttpGet]
        [Route("/v2/pet/findByStatus")]
        [ValidateModelState]
        [SwaggerOperation("FindPetsByStatus")]
        [SwaggerResponse(statusCode: 200, type: typeof(List<Pet>), description: "successful operation")]
        public virtual IActionResult FindPetsByStatus([FromQuery (Name = "status")][Required()]List<string> status)
        { 

            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(List<Pet>));
            //TODO: Uncomment the next line to return response 400 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(400);
            string exampleJson = null;
            exampleJson = "{\n  \"photoUrls\" : [ \"photoUrls\", \"photoUrls\" ],\n  \"name\" : \"doggie\",\n  \"id\" : 0,\n  \"category\" : {\n    \"name\" : \"name\",\n    \"id\" : 6\n  },\n  \"tags\" : [ {\n    \"name\" : \"name\",\n    \"id\" : 1\n  }, {\n    \"name\" : \"name\",\n    \"id\" : 1\n  } ],\n  \"status\" : \"available\"\n}";
            exampleJson = "<Pet>\n  <id>123456789</id>\n  <name>doggie</name>\n  <photoUrls>\n    <photoUrls>aeiou</photoUrls>\n  </photoUrls>\n  <tags>\n  </tags>\n  <status>aeiou</status>\n</Pet>";
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<List<Pet>>(exampleJson)
            : default(List<Pet>);
            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// Finds Pets by tags
        /// </summary>
        /// <remarks>Multiple tags can be provided with comma separated strings. Use tag1, tag2, tag3 for testing.</remarks>
        /// <param name="tags">Tags to filter by</param>
        /// <response code="200">successful operation</response>
        /// <response code="400">Invalid tag value</response>
        [HttpGet]
        [Route("/v2/pet/findByTags")]
        [ValidateModelState]
        [SwaggerOperation("FindPetsByTags")]
        [SwaggerResponse(statusCode: 200, type: typeof(List<Pet>), description: "successful operation")]
        [Obsolete]
        public virtual IActionResult FindPetsByTags([FromQuery (Name = "tags")][Required()]List<string> tags)
        { 

            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(List<Pet>));
            //TODO: Uncomment the next line to return response 400 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(400);
            string exampleJson = null;
            exampleJson = "{\n  \"photoUrls\" : [ \"photoUrls\", \"photoUrls\" ],\n  \"name\" : \"doggie\",\n  \"id\" : 0,\n  \"category\" : {\n    \"name\" : \"name\",\n    \"id\" : 6\n  },\n  \"tags\" : [ {\n    \"name\" : \"name\",\n    \"id\" : 1\n  }, {\n    \"name\" : \"name\",\n    \"id\" : 1\n  } ],\n  \"status\" : \"available\"\n}";
            exampleJson = "<Pet>\n  <id>123456789</id>\n  <name>doggie</name>\n  <photoUrls>\n    <photoUrls>aeiou</photoUrls>\n  </photoUrls>\n  <tags>\n  </tags>\n  <status>aeiou</status>\n</Pet>";
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<List<Pet>>(exampleJson)
            : default(List<Pet>);
            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// Find pet by ID
        /// </summary>
        /// <remarks>Returns a single pet</remarks>
        /// <param name="petId">ID of pet to return</param>
        /// <response code="200">successful operation</response>
        /// <response code="400">Invalid ID supplied</response>
        /// <response code="404">Pet not found</response>
        [HttpGet]
        [Route("/v2/pet/{petId}")]
        [Authorize(Policy = "api_key")]
        [ValidateModelState]
        [SwaggerOperation("GetPetById")]
        [SwaggerResponse(statusCode: 200, type: typeof(Pet), description: "successful operation")]
        public virtual IActionResult GetPetById([FromRoute (Name = "petId")][Required]long petId)
        { 

            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(Pet));
            //TODO: Uncomment the next line to return response 400 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(400);
            //TODO: Uncomment the next line to return response 404 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(404);
            string exampleJson = null;
            exampleJson = "{\n  \"photoUrls\" : [ \"photoUrls\", \"photoUrls\" ],\n  \"name\" : \"doggie\",\n  \"id\" : 0,\n  \"category\" : {\n    \"name\" : \"name\",\n    \"id\" : 6\n  },\n  \"tags\" : [ {\n    \"name\" : \"name\",\n    \"id\" : 1\n  }, {\n    \"name\" : \"name\",\n    \"id\" : 1\n  } ],\n  \"status\" : \"available\"\n}";
            exampleJson = "<Pet>\n  <id>123456789</id>\n  <name>doggie</name>\n  <photoUrls>\n    <photoUrls>aeiou</photoUrls>\n  </photoUrls>\n  <tags>\n  </tags>\n  <status>aeiou</status>\n</Pet>";
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<Pet>(exampleJson)
            : default(Pet);
            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// Update an existing pet
        /// </summary>
        /// <param name="body">Pet object that needs to be added to the store</param>
        /// <response code="400">Invalid ID supplied</response>
        /// <response code="404">Pet not found</response>
        /// <response code="405">Validation exception</response>
        [HttpPut]
        [Route("/v2/pet")]
        [Consumes("application/json", "application/xml")]
        [ValidateModelState]
        [SwaggerOperation("UpdatePet")]
        public virtual IActionResult UpdatePet([FromBody]Pet body)
        { 

            //TODO: Uncomment the next line to return response 400 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(400);
            //TODO: Uncomment the next line to return response 404 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(404);
            //TODO: Uncomment the next line to return response 405 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(405);

            throw new NotImplementedException();
        }

        /// <summary>
        /// Updates a pet in the store with form data
        /// </summary>
        /// <param name="petId">ID of pet that needs to be updated</param>
        /// <param name="name">Updated name of the pet</param>
        /// <param name="status">Updated status of the pet</param>
        /// <response code="405">Invalid input</response>
        [HttpPost]
        [Route("/v2/pet/{petId}")]
        [Consumes("application/x-www-form-urlencoded")]
        [ValidateModelState]
        [SwaggerOperation("UpdatePetWithForm")]
        public virtual IActionResult UpdatePetWithForm([FromRoute (Name = "petId")][Required]long petId, [FromForm (Name = "name")]string name, [FromForm (Name = "status")]string status)
        { 

            //TODO: Uncomment the next line to return response 405 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(405);

            throw new NotImplementedException();
        }

        /// <summary>
        /// uploads an image
        /// </summary>
        /// <param name="petId">ID of pet to update</param>
        /// <param name="additionalMetadata">Additional data to pass to server</param>
        /// <param name="file">file to upload</param>
        /// <response code="200">successful operation</response>
        [HttpPost]
        [Route("/v2/pet/{petId}/uploadImage")]
        [Consumes("multipart/form-data")]
        [ValidateModelState]
        [SwaggerOperation("UploadFile")]
        [SwaggerResponse(statusCode: 200, type: typeof(ApiResponse), description: "successful operation")]
        public virtual IActionResult UploadFile([FromRoute (Name = "petId")][Required]long petId, [FromForm (Name = "additionalMetadata")]string additionalMetadata, IFormFile file)
        { 

            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(ApiResponse));
            string exampleJson = null;
            exampleJson = "{\n  \"code\" : 0,\n  \"type\" : \"type\",\n  \"message\" : \"message\"\n}";
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<ApiResponse>(exampleJson)
            : default(ApiResponse);
            //TODO: Change the data returned
            return new ObjectResult(example);
        }
    }
}
