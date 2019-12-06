﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ProjectApp.Models;

namespace ProjectApp.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20191205181637_statusOrder")]
    partial class statusOrder
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.11-servicing-32099")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ProjectApp.Models.AllDescript", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("id_goods");

                    b.Property<int>("id_longDesc");

                    b.Property<int>("id_shortDesc");

                    b.HasKey("id");

                    b.HasIndex("id_goods");

                    b.HasIndex("id_longDesc");

                    b.HasIndex("id_shortDesc");

                    b.ToTable("allDescripts");
                });

            modelBuilder.Entity("ProjectApp.Models.AvatarUser", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("image");

                    b.Property<int>("user_id");

                    b.HasKey("id");

                    b.HasIndex("user_id")
                        .IsUnique();

                    b.ToTable("AvatarUser");
                });

            modelBuilder.Entity("ProjectApp.Models.BannedUser", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("expires_ban");

                    b.Property<string>("reason_ban")
                        .IsRequired();

                    b.Property<int>("user_id");

                    b.HasKey("id");

                    b.HasIndex("user_id")
                        .IsUnique();

                    b.ToTable("BannedUsers");
                });

            modelBuilder.Entity("ProjectApp.Models.Category", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<int>("id_photo");

                    b.HasKey("id");

                    b.HasIndex("id_photo");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("ProjectApp.Models.CategoryPhoto", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("img");

                    b.HasKey("id");

                    b.ToTable("categoryPhotos");
                });

            modelBuilder.Entity("ProjectApp.Models.Comments", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("comment")
                        .IsRequired();

                    b.Property<DateTime>("datetime");

                    b.Property<int>("id_goods");

                    b.Property<int>("id_user");

                    b.HasKey("id");

                    b.HasIndex("id_goods");

                    b.HasIndex("id_user");

                    b.ToTable("Comments");
                });

            modelBuilder.Entity("ProjectApp.Models.Description", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("desc");

                    b.Property<int>("id_goods");

                    b.HasKey("id");

                    b.HasIndex("id_goods")
                        .IsUnique();

                    b.ToTable("Descriptions");
                });

            modelBuilder.Entity("ProjectApp.Models.Discounts", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("expires_disck");

                    b.Property<int>("id_goods");

                    b.Property<double>("value");

                    b.HasKey("id");

                    b.HasIndex("id_goods");

                    b.ToTable("Discounts");
                });

            modelBuilder.Entity("ProjectApp.Models.FullDescription_Video", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<double>("Chastota_proc");

                    b.Property<double>("Chastota_video");

                    b.Property<string>("Graph_chipset");

                    b.Property<string>("Maker");

                    b.Property<double>("Obsyag_Videopamyati");

                    b.Property<string>("Pruznachennia");

                    b.Property<double>("Rozrydnisct");

                    b.Property<bool>("Stan");

                    b.Property<string>("Tip_Videopamyati");

                    b.Property<string>("Tip_pidkluchenna");

                    b.Property<bool>("display_port");

                    b.Property<bool>("dvi");

                    b.Property<bool>("hdmi");

                    b.Property<int>("id_goods");

                    b.Property<double>("length");

                    b.Property<bool>("vga");

                    b.HasKey("id");

                    b.HasIndex("id_goods")
                        .IsUnique();

                    b.ToTable("FullDescription_Video");
                });

            modelBuilder.Entity("ProjectApp.Models.Goods", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("id_category");

                    b.Property<int>("id_img");

                    b.Property<string>("img");

                    b.Property<bool>("isAvailable");

                    b.Property<bool>("isFavourite");

                    b.Property<string>("name")
                        .IsRequired();

                    b.Property<double>("price");

                    b.HasKey("id");

                    b.HasIndex("id_category");

                    b.ToTable("Goods");
                });

            modelBuilder.Entity("ProjectApp.Models.GoodsPhotos", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("id_goods");

                    b.Property<string>("img");

                    b.HasKey("id");

                    b.HasIndex("id_goods");

                    b.ToTable("GoodsPhotos");
                });

            modelBuilder.Entity("ProjectApp.Models.longDesc", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("description")
                        .IsRequired();

                    b.HasKey("id");

                    b.ToTable("LongDescs");
                });

            modelBuilder.Entity("ProjectApp.Models.OrderDetail", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("GoodsID");

                    b.Property<int>("OrderID");

                    b.Property<double>("price");

                    b.HasKey("id");

                    b.HasIndex("GoodsID");

                    b.HasIndex("OrderID");

                    b.ToTable("orderDetails");
                });

            modelBuilder.Entity("ProjectApp.Models.OrderDetailRegister", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("GoodsID");

                    b.Property<int>("UserID");

                    b.Property<string>("address");

                    b.Property<DateTime>("orderTime");

                    b.Property<double>("price");

                    b.HasKey("id");

                    b.HasIndex("GoodsID");

                    b.HasIndex("UserID");

                    b.ToTable("orderDetailRegisters");
                });

            modelBuilder.Entity("ProjectApp.Models.OrderNoRegister", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("address")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("email")
                        .IsRequired()
                        .HasMaxLength(40);

                    b.Property<string>("first_name")
                        .IsRequired()
                        .HasMaxLength(25);

                    b.Property<string>("last_name")
                        .IsRequired()
                        .HasMaxLength(25);

                    b.Property<DateTime>("orderTime");

                    b.Property<string>("phone")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.HasKey("id");

                    b.ToTable("orderNoRegisters");
                });

            modelBuilder.Entity("ProjectApp.Models.Role", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Roles");
                });

            modelBuilder.Entity("ProjectApp.Models.SelectedProd", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("id_goods");

                    b.Property<int>("id_user");

                    b.HasKey("id");

                    b.HasIndex("id_goods");

                    b.HasIndex("id_user");

                    b.ToTable("selectedProds");
                });

            modelBuilder.Entity("ProjectApp.Models.ShopCartItem", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("Goodsid");

                    b.Property<string>("ShopCartId");

                    b.Property<double>("price");

                    b.HasKey("id");

                    b.HasIndex("Goodsid");

                    b.ToTable("shopCartItems");
                });

            modelBuilder.Entity("ProjectApp.Models.shortDesc", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("description")
                        .IsRequired();

                    b.HasKey("id");

                    b.ToTable("shortDescs");
                });

            modelBuilder.Entity("ProjectApp.Models.StatusOrder", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("id_orderDetail");

                    b.HasKey("id");

                    b.HasIndex("id_orderDetail")
                        .IsUnique();

                    b.ToTable("statusOrders");
                });

            modelBuilder.Entity("ProjectApp.Models.User", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("RegisterTime");

                    b.Property<int?>("RoleId");

                    b.Property<string>("email")
                        .IsRequired();

                    b.Property<string>("first_name");

                    b.Property<string>("last_name");

                    b.Property<string>("password")
                        .IsRequired();

                    b.Property<string>("phone");

                    b.HasKey("id");

                    b.HasIndex("RoleId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("ProjectApp.Models.AllDescript", b =>
                {
                    b.HasOne("ProjectApp.Models.Goods", "Goods")
                        .WithMany("AllDescript")
                        .HasForeignKey("id_goods")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("ProjectApp.Models.longDesc", "longDesc")
                        .WithMany("allDescripts")
                        .HasForeignKey("id_longDesc")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("ProjectApp.Models.shortDesc", "shortDesc")
                        .WithMany("allDescripts")
                        .HasForeignKey("id_shortDesc")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("ProjectApp.Models.AvatarUser", b =>
                {
                    b.HasOne("ProjectApp.Models.User", "User")
                        .WithOne("avatar")
                        .HasForeignKey("ProjectApp.Models.AvatarUser", "user_id")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("ProjectApp.Models.BannedUser", b =>
                {
                    b.HasOne("ProjectApp.Models.User", "User")
                        .WithOne("bannedUser")
                        .HasForeignKey("ProjectApp.Models.BannedUser", "user_id")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("ProjectApp.Models.Category", b =>
                {
                    b.HasOne("ProjectApp.Models.CategoryPhoto", "CategoryPhoto")
                        .WithMany("Categories")
                        .HasForeignKey("id_photo")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("ProjectApp.Models.Comments", b =>
                {
                    b.HasOne("ProjectApp.Models.Goods", "Goods")
                        .WithMany("UsersComment")
                        .HasForeignKey("id_goods")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("ProjectApp.Models.User", "User")
                        .WithMany("Comments")
                        .HasForeignKey("id_user")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("ProjectApp.Models.Description", b =>
                {
                    b.HasOne("ProjectApp.Models.Goods", "Goods")
                        .WithOne("Descriptions")
                        .HasForeignKey("ProjectApp.Models.Description", "id_goods")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("ProjectApp.Models.Discounts", b =>
                {
                    b.HasOne("ProjectApp.Models.Goods", "Goods")
                        .WithMany("Discounts")
                        .HasForeignKey("id_goods")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("ProjectApp.Models.FullDescription_Video", b =>
                {
                    b.HasOne("ProjectApp.Models.Goods", "Goods")
                        .WithOne("FullDescription_video")
                        .HasForeignKey("ProjectApp.Models.FullDescription_Video", "id_goods")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("ProjectApp.Models.Goods", b =>
                {
                    b.HasOne("ProjectApp.Models.Category", "Category")
                        .WithMany("Goods")
                        .HasForeignKey("id_category")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("ProjectApp.Models.GoodsPhotos", b =>
                {
                    b.HasOne("ProjectApp.Models.Goods", "Goods")
                        .WithMany("GoodsPhotos")
                        .HasForeignKey("id_goods")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("ProjectApp.Models.OrderDetail", b =>
                {
                    b.HasOne("ProjectApp.Models.Goods", "goods")
                        .WithMany()
                        .HasForeignKey("GoodsID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("ProjectApp.Models.OrderNoRegister", "Order")
                        .WithMany("orderDetails")
                        .HasForeignKey("OrderID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("ProjectApp.Models.OrderDetailRegister", b =>
                {
                    b.HasOne("ProjectApp.Models.Goods", "Goods")
                        .WithMany()
                        .HasForeignKey("GoodsID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("ProjectApp.Models.User", "User")
                        .WithMany("orderDetailsRegisters")
                        .HasForeignKey("UserID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("ProjectApp.Models.SelectedProd", b =>
                {
                    b.HasOne("ProjectApp.Models.Goods", "Goods")
                        .WithMany("selectedProds")
                        .HasForeignKey("id_goods")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("ProjectApp.Models.User", "User")
                        .WithMany("selectedProds")
                        .HasForeignKey("id_user")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("ProjectApp.Models.ShopCartItem", b =>
                {
                    b.HasOne("ProjectApp.Models.Goods", "Goods")
                        .WithMany()
                        .HasForeignKey("Goodsid");
                });

            modelBuilder.Entity("ProjectApp.Models.StatusOrder", b =>
                {
                    b.HasOne("ProjectApp.Models.OrderDetailRegister", "OrderDetailRegister")
                        .WithOne("statusOrder")
                        .HasForeignKey("ProjectApp.Models.StatusOrder", "id_orderDetail")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("ProjectApp.Models.User", b =>
                {
                    b.HasOne("ProjectApp.Models.Role", "role")
                        .WithMany("Users")
                        .HasForeignKey("RoleId");
                });
#pragma warning restore 612, 618
        }
    }
}
