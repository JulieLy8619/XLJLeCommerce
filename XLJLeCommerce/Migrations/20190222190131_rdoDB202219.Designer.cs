﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using XLJLeCommerce.Data;

namespace XLJLeCommerce.Migrations
{
    [DbContext(typeof(CreaturesDbcontext))]
    [Migration("20190222190131_rdoDB202219")]
    partial class rdoDB202219
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.0-rtm-35687")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("XLJLeCommerce.Models.Product", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description");

                    b.Property<string>("ImageURL");

                    b.Property<string>("Name");

                    b.Property<decimal>("Price");

                    b.Property<string>("Sku");

                    b.HasKey("ID");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            Description = "The Unicorn is like a horse but has a magical horn that makes it more and better than a standard horse.",
                            ImageURL = "~/Unicorn.png",
                            Name = "Unicorn",
                            Price = 20m,
                            Sku = "Unicorn1abc123"
                        },
                        new
                        {
                            ID = 2,
                            Description = "The Dragon is a powerful magical lizard. About 30 times the size of a normal lizard and has special powers like breaths fire.",
                            ImageURL = "~/Dragon2.png",
                            Name = "Dragon",
                            Price = 25m,
                            Sku = "Dragon1abc123"
                        },
                        new
                        {
                            ID = 3,
                            Description = "The Fairy is a tiny magical being. They are about the size of an adult hand, faster than light, and have special fairy dust.",
                            ImageURL = "~/Fairy2Cropped.jpg",
                            Name = "Fairy",
                            Price = 30m,
                            Sku = "Fairy1abc123"
                        },
                        new
                        {
                            ID = 4,
                            Description = "The Griffin is a powerful magical creature. They are about the size of a grown elephant and has 3 times the strength of a whales bite.",
                            ImageURL = "~/Griffin.png",
                            Name = "Griffin",
                            Price = 20m,
                            Sku = "Griffin1abc123"
                        },
                        new
                        {
                            ID = 5,
                            Description = "The Hydra is a tiny but powerful animal, yet as gentle as a dmesticated puppy. They are about the size of two adult hands.",
                            ImageURL = "~/Hydra.png",
                            Name = "Hydra",
                            Price = 10m,
                            Sku = "Hydra1abc123"
                        },
                        new
                        {
                            ID = 6,
                            Description = "The Narwhal is a mystical sea creature who is related to the Unicorn family. They power comes from their horn like the Unicorn, however they are limited to only surviving in water. However, one of their magical powers is changing size to fit whatever water space size.",
                            ImageURL = "~/Narwhal.png",
                            Name = "NawWhal",
                            Price = 50m,
                            Sku = "Narwhal1abc123"
                        },
                        new
                        {
                            ID = 7,
                            Description = "The Troll is a misunderstood being. They often have a facade of ignorance, however they are genius, like Einstein IQ level",
                            ImageURL = "~/Troll.png",
                            Name = "Troll",
                            Price = 15m,
                            Sku = "Troll1abc123"
                        },
                        new
                        {
                            ID = 8,
                            Description = "The Werewolf is a decieving beast because they are human by day, and wolf by night. Becautious as it is unknown but they are the pranksters of the animal world.",
                            ImageURL = "~/WereWolf.png",
                            Name = "Werewolf",
                            Price = 15m,
                            Sku = "Werewolf1abc123"
                        },
                        new
                        {
                            ID = 9,
                            Description = "The Minotaur is a half human half horse. They are the size of a dwarfed giant with a slightly larger horse. Their powers include mind reading and surviving on nothing for a year. They live for several hundreds of years.",
                            ImageURL = "~/Minotaur.jpg",
                            Name = "Minotaur",
                            Price = 20m,
                            Sku = "Minotaur1abc123"
                        },
                        new
                        {
                            ID = 10,
                            Description = "The Mermaid is half human and half fish. Their magic comes from their scales, which allows them to, but not limited to, create an illusion for how others view them.",
                            ImageURL = "~/MermaidCropped.jpg",
                            Name = "Mermaid",
                            Price = 40m,
                            Sku = "Mermaid1abc123"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
