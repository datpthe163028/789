﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Project.Data;

#nullable disable

namespace Project.Migrations
{
    [DbContext(typeof(ShopContext))]
    [Migration("20230620170442_v1")]
    partial class v1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.15")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("longtext");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex");

                    b.ToTable("Roles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("ClaimType")
                        .HasColumnType("longtext");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("longtext");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("RoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("varchar(255)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("longtext");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("tinyint(1)");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("longtext");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("longtext");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("longtext");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex");

                    b.ToTable("Users", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("ClaimType")
                        .HasColumnType("longtext");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("longtext");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("UserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("varchar(128)");

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128)
                        .HasColumnType("varchar(128)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("longtext");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("UserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("RoleId")
                        .HasColumnType("varchar(255)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("UserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("varchar(128)");

                    b.Property<string>("Name")
                        .HasMaxLength(128)
                        .HasColumnType("varchar(128)");

                    b.Property<string>("Value")
                        .HasColumnType("longtext");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("UserTokens", (string)null);
                });

            modelBuilder.Entity("Project.Models.Address", b =>
                {
                    b.Property<int>("AddressId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("District")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<bool>("HomeStatus")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("Province")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Town")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.HasKey("AddressId");

                    b.HasIndex("UserId");

                    b.ToTable("Addresses");
                });

            modelBuilder.Entity("Project.Models.Bill", b =>
                {
                    b.Property<int>("BillId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("BillStatus")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Note")
                        .HasColumnType("longtext");

                    b.Property<int>("PaymentCode")
                        .HasColumnType("int");

                    b.Property<string>("PaymentMethod")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<DateTime>("PurchaseDate")
                        .HasColumnType("date");

                    b.Property<string>("ShippingAddress")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<double>("ShippingFee")
                        .HasColumnType("double");

                    b.Property<double>("TotalPrice")
                        .HasColumnType("double");

                    b.Property<int>("TransportId")
                        .HasColumnType("int");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.HasKey("BillId");

                    b.HasIndex("PaymentCode");

                    b.HasIndex("TransportId");

                    b.HasIndex("UserId");

                    b.ToTable("Bills");
                });

            modelBuilder.Entity("Project.Models.BillDetail", b =>
                {
                    b.Property<int>("BillDetailId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("BillId")
                        .HasColumnType("int");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("quantity")
                        .HasColumnType("int");

                    b.HasKey("BillDetailId");

                    b.HasIndex("BillId");

                    b.HasIndex("ProductId");

                    b.ToTable("BillDetails");
                });

            modelBuilder.Entity("Project.Models.Blog", b =>
                {
                    b.Property<int>("Blogid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<bool?>("HomeStatus")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("content")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Blogid");

                    b.ToTable("Blogs");
                });

            modelBuilder.Entity("Project.Models.Cart", b =>
                {
                    b.Property<int>("CartId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.HasKey("CartId");

                    b.HasIndex("UserId");

                    b.ToTable("Carts");
                });

            modelBuilder.Entity("Project.Models.CartItem", b =>
                {
                    b.Property<int>("CartItemId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("CartId")
                        .HasColumnType("int");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("CartItemId");

                    b.HasIndex("CartId");

                    b.HasIndex("ProductId");

                    b.ToTable("CartItems");
                });

            modelBuilder.Entity("Project.Models.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("CategoryName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("CategoryId");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("Project.Models.Feedback", b =>
                {
                    b.Property<int>("FeedbackId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("feedback_id");

                    b.Property<string>("FeedbackAnswer")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("varchar(250)")
                        .HasColumnName("feedback_answer");

                    b.Property<DateTime>("FeedbackDate")
                        .HasColumnType("date")
                        .HasColumnName("feedback_date");

                    b.Property<string>("FeedbackDetail")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("varchar(250)")
                        .HasColumnName("feedback_detail");

                    b.Property<string>("FeedbackStatus")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("feedback_status");

                    b.Property<string>("FeedbackTitle")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("feedback_title");

                    b.Property<int>("ProductId")
                        .HasColumnType("int")
                        .HasColumnName("product_id");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("varchar(255)")
                        .HasColumnName("user_id");

                    b.HasKey("FeedbackId");

                    b.HasIndex("ProductId");

                    b.HasIndex("UserId");

                    b.ToTable("Feedbacks");
                });

            modelBuilder.Entity("Project.Models.ImageBlog", b =>
                {
                    b.Property<int>("ImageBlogId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("BlogId")
                        .HasColumnType("int");

                    b.Property<string>("ImageURL")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("ImageBlogId");

                    b.HasIndex("BlogId");

                    b.ToTable("ImageBlogs");
                });

            modelBuilder.Entity("Project.Models.ImageProduct", b =>
                {
                    b.Property<int>("ImageProductId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("ImageURL")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.HasKey("ImageProductId");

                    b.HasIndex("ProductId");

                    b.ToTable("ImageProducts");
                });

            modelBuilder.Entity("Project.Models.Payment", b =>
                {
                    b.Property<int>("PaymentCode")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("PaymentName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("PaymentStatus")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("PaymentCode");

                    b.ToTable("Payments");
                });

            modelBuilder.Entity("Project.Models.Product", b =>
                {
                    b.Property<int>("ProductId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int?>("BlogId")
                        .HasColumnType("int");

                    b.Property<bool>("HomeStatus")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("ImageMain")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<DateTime>("ImportDate")
                        .HasColumnType("date");

                    b.Property<bool>("IsAvailble")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("ListColor")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("ListSize")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<double?>("PerDiscount")
                        .HasColumnType("double");

                    b.Property<string>("ProductDescription")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("ProductName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<double>("ProductPrice")
                        .HasColumnType("double");

                    b.Property<int>("ProductQuantities")
                        .HasColumnType("int");

                    b.Property<int>("SubCategoryID")
                        .HasColumnType("int");

                    b.Property<bool?>("typeGender")
                        .HasColumnType("tinyint(1)");

                    b.HasKey("ProductId");

                    b.HasIndex("BlogId");

                    b.HasIndex("SubCategoryID");

                    b.ToTable("products", (string)null);
                });

            modelBuilder.Entity("Project.Models.SubCategory", b =>
                {
                    b.Property<int>("SubCategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("CateogoryId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("SubCategoryId");

                    b.HasIndex("CateogoryId");

                    b.ToTable("SubCategory");
                });

            modelBuilder.Entity("Project.Models.Transport", b =>
                {
                    b.Property<int>("TransportId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("TransportName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("TransportStatus")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("TransportId");

                    b.ToTable("Transports");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Project.Models.Address", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("Project.Models.Bill", b =>
                {
                    b.HasOne("Project.Models.Payment", "PaymentCodeNavigation")
                        .WithMany("Bills")
                        .HasForeignKey("PaymentCode")
                        .IsRequired()
                        .HasConstraintName("FK__bills__payment_c__38996AB5");

                    b.HasOne("Project.Models.Transport", "Transport")
                        .WithMany("Bills")
                        .HasForeignKey("TransportId")
                        .IsRequired()
                        .HasConstraintName("FK__bills__transport__3A81B327");

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .IsRequired()
                        .HasConstraintName("FK__bills__user_id__398D8EEE");

                    b.Navigation("PaymentCodeNavigation");

                    b.Navigation("Transport");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Project.Models.BillDetail", b =>
                {
                    b.HasOne("Project.Models.Bill", "Bill")
                        .WithMany("BillDetails")
                        .HasForeignKey("BillId")
                        .IsRequired()
                        .HasConstraintName("FK__bill_deta__bill___3E52440B");

                    b.HasOne("Project.Models.Product", "Product")
                        .WithMany("BillDetails")
                        .HasForeignKey("ProductId")
                        .IsRequired()
                        .HasConstraintName("FK__bill_deta__produ__3F466844");

                    b.Navigation("Bill");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("Project.Models.Cart", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("Project.Models.CartItem", b =>
                {
                    b.HasOne("Project.Models.Cart", "cart")
                        .WithMany("CartItems")
                        .HasForeignKey("CartId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Project.Models.Product", "product")
                        .WithMany("CartItems")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("cart");

                    b.Navigation("product");
                });

            modelBuilder.Entity("Project.Models.Feedback", b =>
                {
                    b.HasOne("Project.Models.Product", "Product")
                        .WithMany("Feedbacks")
                        .HasForeignKey("ProductId")
                        .IsRequired()
                        .HasConstraintName("FK__feedback__produc__403A8C7D");

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .IsRequired()
                        .HasConstraintName("FK__feedback__user_i__276EDEB3");

                    b.Navigation("Product");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Project.Models.ImageBlog", b =>
                {
                    b.HasOne("Project.Models.Blog", "Blog")
                        .WithMany("ImageBlogs")
                        .HasForeignKey("BlogId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Blog");
                });

            modelBuilder.Entity("Project.Models.ImageProduct", b =>
                {
                    b.HasOne("Project.Models.Product", "Product")
                        .WithMany("ImageProducts")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");
                });

            modelBuilder.Entity("Project.Models.Product", b =>
                {
                    b.HasOne("Project.Models.Blog", "Blog")
                        .WithMany("Products")
                        .HasForeignKey("BlogId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Project.Models.SubCategory", "SubCategory")
                        .WithMany("Products")
                        .HasForeignKey("SubCategoryID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Blog");

                    b.Navigation("SubCategory");
                });

            modelBuilder.Entity("Project.Models.SubCategory", b =>
                {
                    b.HasOne("Project.Models.Category", "Cateogory")
                        .WithMany("SubCategories")
                        .HasForeignKey("CateogoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cateogory");
                });

            modelBuilder.Entity("Project.Models.Bill", b =>
                {
                    b.Navigation("BillDetails");
                });

            modelBuilder.Entity("Project.Models.Blog", b =>
                {
                    b.Navigation("ImageBlogs");

                    b.Navigation("Products");
                });

            modelBuilder.Entity("Project.Models.Cart", b =>
                {
                    b.Navigation("CartItems");
                });

            modelBuilder.Entity("Project.Models.Category", b =>
                {
                    b.Navigation("SubCategories");
                });

            modelBuilder.Entity("Project.Models.Payment", b =>
                {
                    b.Navigation("Bills");
                });

            modelBuilder.Entity("Project.Models.Product", b =>
                {
                    b.Navigation("BillDetails");

                    b.Navigation("CartItems");

                    b.Navigation("Feedbacks");

                    b.Navigation("ImageProducts");
                });

            modelBuilder.Entity("Project.Models.SubCategory", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("Project.Models.Transport", b =>
                {
                    b.Navigation("Bills");
                });
#pragma warning restore 612, 618
        }
    }
}
