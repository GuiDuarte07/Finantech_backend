﻿using AutoMapper;
using Finantech.DTOs.Account;
using Finantech.DTOs.Category;
using Finantech.DTOs.CreditCard;
using Finantech.DTOs.CreditPurcchase;
using Finantech.DTOs.Expense;
using Finantech.DTOs.Income;
using Finantech.DTOs.Invoice;
using Finantech.DTOs.TransferenceDTO;
using Finantech.DTOs.User;
using Finantech.Models.Entities;

namespace Finantech.Profiles
{
    public class MapperProfile : Profile
    {
        public MapperProfile() 
        {
            CreateMap<CreateAccountRequest, Account>()
                .ForMember(dest => dest.CreatedAt, opt => opt.Ignore())
                .ForMember(dest => dest.UpdatedAt, opt => opt.Ignore())
                .AfterMap((src, dest) =>
                {
                    dest.CreatedAt = DateTime.Now;
                    dest.UpdatedAt = DateTime.Now;
                });

            CreateMap<Account, InfoAccountResponse>();

            CreateMap<UpdateAccountRequest, Account>()
                .AfterMap((src, dest) =>
                {
                    dest.UpdatedAt = DateTime.Now;
                });

            CreateMap<User, InfoUserResponse>()
                .ForMember(dest => dest.Accounts, opt => opt.MapFrom(src => src.Accounts));

            CreateMap<CreateExpenseRequest, Expense>()
                .ForMember(dest => dest.CreatedAt, opt => opt.Ignore())
                .ForMember(dest => dest.UpdatedAt, opt => opt.Ignore())
                .AfterMap((src, dest) =>
                {
                    dest.CreatedAt = DateTime.Now;
                    dest.UpdatedAt = DateTime.Now;
                });
            CreateMap<Expense, InfoExpenseResponse>();
            CreateMap<UpdateExpenseRequest, Expense>()
                .AfterMap((src, dest) =>
                {
                    dest.UpdatedAt = DateTime.Now;
                });

            CreateMap<CreateIncomeRequest, Income>()
                .ForMember(dest => dest.CreatedAt, opt => opt.Ignore())
                .ForMember(dest => dest.UpdatedAt, opt => opt.Ignore())
                .AfterMap((src, dest) =>
                {
                    dest.CreatedAt = DateTime.Now;
                    dest.UpdatedAt = DateTime.Now;
                });
            CreateMap<Income, InfoIncomeResponse>();



            CreateMap<CreateCategoryRequest, Category>()
                .ForMember(dest => dest.CreatedAt, opt => opt.Ignore())
                .ForMember(dest => dest.UpdatedAt, opt => opt.Ignore())
                .AfterMap((src, dest) =>
                {
                    dest.CreatedAt = DateTime.Now;
                    dest.UpdatedAt = DateTime.Now;
                });
            CreateMap<Category, InfoCategoryResponse>();
            CreateMap<UpdateCategoryRequest, Category>()
                .AfterMap((src, dest) =>
                {
                    dest.UpdatedAt = DateTime.Now;
                });


            CreateMap<CreateCreditCardRequest, CreditCard>()
                .ForMember(dest => dest.CreatedAt, opt => opt.Ignore())
                .ForMember(dest => dest.UpdatedAt, opt => opt.Ignore())
                .AfterMap((src, dest) =>
                {
                    dest.CreatedAt = DateTime.Now;
                    dest.UpdatedAt = DateTime.Now;
                });
            CreateMap<CreditCard, InfoCreditCardResponse>();
            CreateMap<UpdateCreditCardRequest, CreditCard>()
                .AfterMap((src, dest) =>
                {
                    dest.UpdatedAt = DateTime.Now;
                });

            CreateMap<CreateCreditPurchaseRequest, CreditPurchase>()
                .ForMember(dest => dest.CreatedAt, opt => opt.Ignore())
                .ForMember(dest => dest.UpdatedAt, opt => opt.Ignore())
                .AfterMap((src, dest) =>
                {
                    dest.CreatedAt = DateTime.Now;
                    dest.UpdatedAt = DateTime.Now;
                });
            CreateMap<CreditPurchase, InfoCreditPurchaseResponse>();


            CreateMap<Invoice, InfoInvoiceResponse>();

            CreateMap<CreteInvoicePaymentRequest, InvoicePayment>();
            CreateMap<InvoicePayment, InfoInvoicePaymentResponse>();

            CreateMap<CreateTransferenceRequest, Transference>()
                .ForMember(dest => dest.CreatedAt, opt => opt.Ignore())
                .ForMember(dest => dest.UpdatedAt, opt => opt.Ignore())
                .AfterMap((src, dest) =>
                {
                    dest.CreatedAt = DateTime.Now;
                    dest.UpdatedAt = DateTime.Now;
                });
        }
    }
}
