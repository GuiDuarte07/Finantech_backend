﻿using Finantech.Decorators;
using Finantech.DTOs.CreditCard;
using Finantech.DTOs.CreditPurcchase;
using Finantech.Services;
using Finantech.Services.Interfaces;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace Finantech.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [ExtractTokenInfo]
    public class CreditCardController : ControllerBase
    {
        private readonly ICreditCardService _creditCardService;
        public CreditCardController(ICreditCardService creditCardService)
        {
            _creditCardService = creditCardService;
        }

        [HttpPost("CreateCreditCard")]
        public async Task<IActionResult> CreateCreditCard(CreateCreditCardRequest request)
        {
            int userId = (int)(HttpContext.Items["UserId"] as int?)!;

            try
            {
                var createdCreditCard = await _creditCardService.CreateCreditCardAsync(request, userId);

                return Created("", createdCreditCard);
            } 
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPatch("UpdateCreditCard")]
        public async Task<IActionResult> UpdateCreditCard(UpdateCreditCardRequest request)
        {
            int userId = (int)(HttpContext.Items["UserId"] as int?)!;

            try
            {
                var updatedCreditCard = await _creditCardService.UpdateCreditCardAsync(request, userId);

                return Created("", updatedCreditCard);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost("CreateCreditPurchase")]
        public async Task<IActionResult> CreateCreditPurchase(CreateCreditPurchaseRequest request)
        {
            int userId = (int)(HttpContext.Items["UserId"] as int?)!;

            try
            {
                var updatedCreditCard = await _creditCardService.CreateCreditPurchaseAsync(request, userId);

                return Created("", updatedCreditCard);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("GetInvoicesWithPagination")]
        public async Task<IActionResult> GetInvoicesWithPagination
        (
            [FromQuery] int pageNumber,
            [FromQuery] DateTime? startDate,
            [FromQuery] DateTime? endDate,
            [FromQuery] int? accountId
        )
        {
            int userId = (int)(HttpContext.Items["UserId"] as int?)!;
            const int pageSize = 12;

            DateTime startDateSet = startDate ?? DateTime.MinValue;
            DateTime endDateSet = endDate ?? DateTime.Now;

            if (pageNumber < 1) pageNumber = 1;

            try
            {
                var invoices = await _creditCardService.GetInvoicesWithPaginationAsync(pageNumber, pageSize, userId, startDateSet, endDateSet, accountId);

                return Ok(invoices);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
