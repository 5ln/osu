﻿// <auto-generated />
using System;

#nullable disable
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using osu.Game.Database;

namespace osu.Game.Migrations
{
    [DbContext(typeof(OsuDbContext))]
    [Migration("20180913080842_AddRankStatus")]
    partial class AddRankStatus
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.2-rtm-30932");

            modelBuilder.Entity("osu.Game.Beatmaps.BeatmapDifficulty", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<float>("ApproachRate");

                    b.Property<float>("CircleSize");

                    b.Property<float>("DrainRate");

                    b.Property<float>("OverallDifficulty");

                    b.Property<double>("SliderMultiplier");

                    b.Property<double>("SliderTickRate");

                    b.HasKey("ID");

                    b.ToTable("BeatmapDifficulty");
                });

            modelBuilder.Entity("osu.Game.Beatmaps.BeatmapInfo", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AudioLeadIn");

                    b.Property<int>("BaseDifficultyID");

                    b.Property<int>("BeatDivisor");

                    b.Property<int>("BeatmapSetInfoID");

                    b.Property<bool>("Countdown");

                    b.Property<double>("DistanceSpacing");

                    b.Property<int>("GridSize");

                    b.Property<string>("Hash");

                    b.Property<bool>("Hidden");

                    b.Property<bool>("LetterboxInBreaks");

                    b.Property<string>("MD5Hash");

                    b.Property<int?>("MetadataID");

                    b.Property<int?>("OnlineBeatmapID");

                    b.Property<string>("Path");

                    b.Property<int>("RulesetID");

                    b.Property<bool>("SpecialStyle");

                    b.Property<float>("StackLeniency");

                    b.Property<double>("StarDifficulty");

                    b.Property<int>("Status");

                    b.Property<string>("StoredBookmarks");

                    b.Property<double>("TimelineZoom");

                    b.Property<string>("Version");

                    b.Property<bool>("WidescreenStoryboard");

                    b.HasKey("ID");

                    b.HasIndex("BaseDifficultyID");

                    b.HasIndex("BeatmapSetInfoID");

                    b.HasIndex("Hash");

                    b.HasIndex("MD5Hash");

                    b.HasIndex("MetadataID");

                    b.HasIndex("OnlineBeatmapID")
                        .IsUnique();

                    b.HasIndex("RulesetID");

                    b.ToTable("BeatmapInfo");
                });

            modelBuilder.Entity("osu.Game.Beatmaps.BeatmapMetadata", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Artist");

                    b.Property<string>("ArtistUnicode");

                    b.Property<string>("AudioFile");

                    b.Property<string>("AuthorString")
                        .HasColumnName("Author");

                    b.Property<string>("BackgroundFile");

                    b.Property<int>("PreviewTime");

                    b.Property<string>("Source");

                    b.Property<string>("Tags");

                    b.Property<string>("Title");

                    b.Property<string>("TitleUnicode");

                    b.HasKey("ID");

                    b.ToTable("BeatmapMetadata");
                });

            modelBuilder.Entity("osu.Game.Beatmaps.BeatmapSetFileInfo", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("BeatmapSetInfoID");

                    b.Property<int>("FileInfoID");

                    b.Property<string>("Filename")
                        .IsRequired();

                    b.HasKey("ID");

                    b.HasIndex("BeatmapSetInfoID");

                    b.HasIndex("FileInfoID");

                    b.ToTable("BeatmapSetFileInfo");
                });

            modelBuilder.Entity("osu.Game.Beatmaps.BeatmapSetInfo", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("DeletePending");

                    b.Property<string>("Hash");

                    b.Property<int?>("MetadataID");

                    b.Property<int?>("OnlineBeatmapSetID");

                    b.Property<bool>("Protected");

                    b.Property<int>("Status");

                    b.HasKey("ID");

                    b.HasIndex("DeletePending");

                    b.HasIndex("Hash")
                        .IsUnique();

                    b.HasIndex("MetadataID");

                    b.HasIndex("OnlineBeatmapSetID")
                        .IsUnique();

                    b.ToTable("BeatmapSetInfo");
                });

            modelBuilder.Entity("osu.Game.Configuration.DatabasedSetting", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("IntKey")
                        .HasColumnName("Key");

                    b.Property<int?>("RulesetID");

                    b.Property<string>("StringValue")
                        .HasColumnName("Value");

                    b.Property<int?>("Variant");

                    b.HasKey("ID");

                    b.HasIndex("RulesetID", "Variant");

                    b.ToTable("Settings");
                });

            modelBuilder.Entity("osu.Game.Input.Bindings.DatabasedKeyBinding", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("IntAction")
                        .HasColumnName("Action");

                    b.Property<string>("KeysString")
                        .HasColumnName("Keys");

                    b.Property<int?>("RulesetID");

                    b.Property<int?>("Variant");

                    b.HasKey("ID");

                    b.HasIndex("IntAction");

                    b.HasIndex("RulesetID", "Variant");

                    b.ToTable("KeyBinding");
                });

            modelBuilder.Entity("osu.Game.IO.FileInfo", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Hash");

                    b.Property<int>("ReferenceCount");

                    b.HasKey("ID");

                    b.HasIndex("Hash")
                        .IsUnique();

                    b.HasIndex("ReferenceCount");

                    b.ToTable("FileInfo");
                });

            modelBuilder.Entity("osu.Game.Rulesets.RulesetInfo", b =>
                {
                    b.Property<int?>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("Available");

                    b.Property<string>("InstantiationInfo");

                    b.Property<string>("Name");

                    b.Property<string>("ShortName");

                    b.HasKey("ID");

                    b.HasIndex("Available");

                    b.HasIndex("ShortName")
                        .IsUnique();

                    b.ToTable("RulesetInfo");
                });

            modelBuilder.Entity("osu.Game.Skinning.SkinFileInfo", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("FileInfoID");

                    b.Property<string>("Filename")
                        .IsRequired();

                    b.Property<int>("SkinInfoID");

                    b.HasKey("ID");

                    b.HasIndex("FileInfoID");

                    b.HasIndex("SkinInfoID");

                    b.ToTable("SkinFileInfo");
                });

            modelBuilder.Entity("osu.Game.Skinning.SkinInfo", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Creator");

                    b.Property<bool>("DeletePending");

                    b.Property<string>("Name");

                    b.HasKey("ID");

                    b.ToTable("SkinInfo");
                });

            modelBuilder.Entity("osu.Game.Beatmaps.BeatmapInfo", b =>
                {
                    b.HasOne("osu.Game.Beatmaps.BeatmapDifficulty", "BaseDifficulty")
                        .WithMany()
                        .HasForeignKey("BaseDifficultyID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("osu.Game.Beatmaps.BeatmapSetInfo", "BeatmapSet")
                        .WithMany("Beatmaps")
                        .HasForeignKey("BeatmapSetInfoID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("osu.Game.Beatmaps.BeatmapMetadata", "Metadata")
                        .WithMany("Beatmaps")
                        .HasForeignKey("MetadataID");

                    b.HasOne("osu.Game.Rulesets.RulesetInfo", "Ruleset")
                        .WithMany()
                        .HasForeignKey("RulesetID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("osu.Game.Beatmaps.BeatmapSetFileInfo", b =>
                {
                    b.HasOne("osu.Game.Beatmaps.BeatmapSetInfo")
                        .WithMany("Files")
                        .HasForeignKey("BeatmapSetInfoID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("osu.Game.IO.FileInfo", "FileInfo")
                        .WithMany()
                        .HasForeignKey("FileInfoID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("osu.Game.Beatmaps.BeatmapSetInfo", b =>
                {
                    b.HasOne("osu.Game.Beatmaps.BeatmapMetadata", "Metadata")
                        .WithMany("BeatmapSets")
                        .HasForeignKey("MetadataID");
                });

            modelBuilder.Entity("osu.Game.Skinning.SkinFileInfo", b =>
                {
                    b.HasOne("osu.Game.IO.FileInfo", "FileInfo")
                        .WithMany()
                        .HasForeignKey("FileInfoID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("osu.Game.Skinning.SkinInfo")
                        .WithMany("Files")
                        .HasForeignKey("SkinInfoID")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
