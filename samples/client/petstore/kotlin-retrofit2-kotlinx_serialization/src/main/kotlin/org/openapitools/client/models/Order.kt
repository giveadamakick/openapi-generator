/**
 * OpenAPI Petstore
 *
 * This is a sample server Petstore server. For this sample, you can use the api key `special-key` to test the authorization filters.
 *
 * The version of the OpenAPI document: 1.0.0
 * 
 *
 * Please note:
 * This class is auto generated by OpenAPI Generator (https://openapi-generator.tech).
 * Do not edit this file manually.
 */

@file:Suppress(
    "ArrayInDataClass",
    "EnumEntryName",
    "RemoveRedundantQualifierName",
    "UnusedImport"
)

package org.openapitools.client.models


import kotlinx.serialization.Serializable as KSerializable
import kotlinx.serialization.SerialName
import kotlinx.serialization.Contextual
import java.io.Serializable

/**
 * An order for a pets from the pet store
 *
 * @param id 
 * @param petId 
 * @param quantity 
 * @param shipDate 
 * @param status Order Status
 * @param complete 
 */
@KSerializable
data class Order (

    @SerialName(value = "id")
    val id: kotlin.Long? = null,

    @SerialName(value = "petId")
    val petId: kotlin.Long? = null,

    @SerialName(value = "quantity")
    val quantity: kotlin.Int? = null,

    @Contextual @SerialName(value = "shipDate")
    val shipDate: java.time.OffsetDateTime? = null,

    /* Order Status */
    @SerialName(value = "status")
    val status: Order.Status? = null,

    @SerialName(value = "complete")
    val complete: kotlin.Boolean? = null

) : Serializable {
    companion object {
        private const val serialVersionUID: Long = 123
    }

    /**
     * Order Status
     *
     * Values: PLACED,APPROVED,DELIVERED
     */
    @KSerializable
    enum class Status(val value: kotlin.String) {
        @SerialName(value = "placed") PLACED("placed"),
        @SerialName(value = "approved") APPROVED("approved"),
        @SerialName(value = "delivered") DELIVERED("delivered");
    }
}

