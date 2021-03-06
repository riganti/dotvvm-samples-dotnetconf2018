﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotNetConfDemo1.Model
{
    public class AppDbContext : DbContext
    {

        public virtual DbSet<Country> Countries { get; set; }

        public virtual DbSet<State> States { get; set; }

        public AppDbContext() : base()
        {
        }

        public AppDbContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlite("Data Source=data.sqlite");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Country>(c =>
            {
                c.HasData(
                    new Country() { Id = 1, Name = "Afghanistan" },
                    new Country() { Id = 2, Name = "Albania" },
                    new Country() { Id = 3, Name = "Algeria" },
                    new Country() { Id = 4, Name = "Andorra" },
                    new Country() { Id = 5, Name = "Angola" },
                    new Country() { Id = 6, Name = "Antigua and Barbuda" },
                    new Country() { Id = 7, Name = "Argentina" },
                    new Country() { Id = 8, Name = "Armenia" },
                    new Country() { Id = 9, Name = "Australia" },
                    new Country() { Id = 10, Name = "Austria" },
                    new Country() { Id = 11, Name = "Azerbaijan" },
                    new Country() { Id = 12, Name = "Bahamas" },
                    new Country() { Id = 13, Name = "Bahrain" },
                    new Country() { Id = 14, Name = "Bangladesh" },
                    new Country() { Id = 15, Name = "Barbados" },
                    new Country() { Id = 16, Name = "Belarus" },
                    new Country() { Id = 17, Name = "Belgium" },
                    new Country() { Id = 18, Name = "Belize" },
                    new Country() { Id = 19, Name = "Benin" },
                    new Country() { Id = 20, Name = "Bhutan" },
                    new Country() { Id = 21, Name = "Bolivia (Plurinational State of)" },
                    new Country() { Id = 22, Name = "Bosnia and Herzegovina" },
                    new Country() { Id = 23, Name = "Botswana" },
                    new Country() { Id = 24, Name = "Brazil" },
                    new Country() { Id = 25, Name = "Brunei Darussalam" },
                    new Country() { Id = 26, Name = "Bulgaria" },
                    new Country() { Id = 27, Name = "Burkina Faso" },
                    new Country() { Id = 28, Name = "Burundi" },
                    new Country() { Id = 29, Name = "Cambodia" },
                    new Country() { Id = 30, Name = "Cameroon" },
                    new Country() { Id = 31, Name = "Canada" },
                    new Country() { Id = 32, Name = "Cape Verde" },
                    new Country() { Id = 33, Name = "Central African Republic" },
                    new Country() { Id = 34, Name = "Chad" },
                    new Country() { Id = 35, Name = "Chile" },
                    new Country() { Id = 36, Name = "China" },
                    new Country() { Id = 37, Name = "Colombia" },
                    new Country() { Id = 38, Name = "Comoros" },
                    new Country() { Id = 39, Name = "Congo" },
                    new Country() { Id = 40, Name = "Costa Rica" },
                    new Country() { Id = 41, Name = "Côte d'Ivoire" },
                    new Country() { Id = 42, Name = "Croatia" },
                    new Country() { Id = 43, Name = "Cuba" },
                    new Country() { Id = 44, Name = "Cyprus" },
                    new Country() { Id = 45, Name = "Czech Republic" },
                    new Country() { Id = 46, Name = "Democratic People's Republic of Korea" },
                    new Country() { Id = 47, Name = "Democratic Republic of the Congo" },
                    new Country() { Id = 48, Name = "Denmark" },
                    new Country() { Id = 49, Name = "Djibouti" },
                    new Country() { Id = 50, Name = "Dominica" },
                    new Country() { Id = 51, Name = "Dominican Republic" },
                    new Country() { Id = 52, Name = "Ecuador" },
                    new Country() { Id = 53, Name = "Egypt" },
                    new Country() { Id = 54, Name = "El Salvador" },
                    new Country() { Id = 55, Name = "Equatorial Guinea" },
                    new Country() { Id = 56, Name = "Eritrea" },
                    new Country() { Id = 57, Name = "Estonia" },
                    new Country() { Id = 58, Name = "Ethiopia" },
                    new Country() { Id = 59, Name = "Fiji" },
                    new Country() { Id = 60, Name = "Finland" },
                    new Country() { Id = 61, Name = "France" },
                    new Country() { Id = 62, Name = "Gabon" },
                    new Country() { Id = 63, Name = "Gambia" },
                    new Country() { Id = 64, Name = "Georgia" },
                    new Country() { Id = 65, Name = "Germany" },
                    new Country() { Id = 66, Name = "Ghana" },
                    new Country() { Id = 67, Name = "Greece" },
                    new Country() { Id = 68, Name = "Grenada" },
                    new Country() { Id = 69, Name = "Guatemala" },
                    new Country() { Id = 70, Name = "Guinea" },
                    new Country() { Id = 71, Name = "Guinea-Bissau" },
                    new Country() { Id = 72, Name = "Guyana" },
                    new Country() { Id = 73, Name = "Haiti" },
                    new Country() { Id = 74, Name = "Honduras" },
                    new Country() { Id = 75, Name = "Hungary" },
                    new Country() { Id = 76, Name = "Iceland" },
                    new Country() { Id = 77, Name = "India" },
                    new Country() { Id = 78, Name = "Indonesia" },
                    new Country() { Id = 79, Name = "Iran (Islamic Republic of)" },
                    new Country() { Id = 80, Name = "Iraq" },
                    new Country() { Id = 81, Name = "Ireland" },
                    new Country() { Id = 82, Name = "Israel" },
                    new Country() { Id = 83, Name = "Italy" },
                    new Country() { Id = 84, Name = "Jamaica" },
                    new Country() { Id = 85, Name = "Japan" },
                    new Country() { Id = 86, Name = "Jordan" },
                    new Country() { Id = 87, Name = "Kazakhstan" },
                    new Country() { Id = 88, Name = "Kenya" },
                    new Country() { Id = 89, Name = "Kiribati" },
                    new Country() { Id = 90, Name = "Kuwait" },
                    new Country() { Id = 91, Name = "Kyrgyzstan" },
                    new Country() { Id = 92, Name = "Lao People's Democratic Republic" },
                    new Country() { Id = 93, Name = "Latvia" },
                    new Country() { Id = 94, Name = "Lebanon" },
                    new Country() { Id = 95, Name = "Lesotho" },
                    new Country() { Id = 96, Name = "Liberia" },
                    new Country() { Id = 97, Name = "Libyan Arab Jamahiriya" },
                    new Country() { Id = 98, Name = "Liechtenstein" },
                    new Country() { Id = 99, Name = "Lithuania" },
                    new Country() { Id = 100, Name = "Luxembourg" },
                    new Country() { Id = 101, Name = "Madagascar" },
                    new Country() { Id = 102, Name = "Malawi" },
                    new Country() { Id = 103, Name = "Malaysia" },
                    new Country() { Id = 104, Name = "Maldives" },
                    new Country() { Id = 105, Name = "Mali" },
                    new Country() { Id = 106, Name = "Malta" },
                    new Country() { Id = 107, Name = "Marshall Islands" },
                    new Country() { Id = 108, Name = "Mauritania" },
                    new Country() { Id = 109, Name = "Mauritius" },
                    new Country() { Id = 110, Name = "Mexico" },
                    new Country() { Id = 111, Name = "Micronesia (Federated States of)" },
                    new Country() { Id = 112, Name = "Monaco" },
                    new Country() { Id = 113, Name = "Mongolia" },
                    new Country() { Id = 114, Name = "Montenegro" },
                    new Country() { Id = 115, Name = "Morocco" },
                    new Country() { Id = 116, Name = "Mozambique" },
                    new Country() { Id = 117, Name = "Myanmar" },
                    new Country() { Id = 118, Name = "Namibia" },
                    new Country() { Id = 119, Name = "Nauru" },
                    new Country() { Id = 120, Name = "Nepal" },
                    new Country() { Id = 121, Name = "Netherlands" },
                    new Country() { Id = 122, Name = "New Zealand" },
                    new Country() { Id = 123, Name = "Nicaragua" },
                    new Country() { Id = 124, Name = "Niger" },
                    new Country() { Id = 125, Name = "Nigeria" },
                    new Country() { Id = 126, Name = "Norway" },
                    new Country() { Id = 127, Name = "Oman" },
                    new Country() { Id = 128, Name = "Pakistan" },
                    new Country() { Id = 129, Name = "Palau" },
                    new Country() { Id = 130, Name = "Panama" },
                    new Country() { Id = 131, Name = "Papua New Guinea" },
                    new Country() { Id = 132, Name = "Paraguay" },
                    new Country() { Id = 133, Name = "Peru" },
                    new Country() { Id = 134, Name = "Philippines" },
                    new Country() { Id = 135, Name = "Poland" },
                    new Country() { Id = 136, Name = "Portugal" },
                    new Country() { Id = 137, Name = "Qatar" },
                    new Country() { Id = 138, Name = "Republic of Korea" },
                    new Country() { Id = 139, Name = "Republic of Moldova" },
                    new Country() { Id = 140, Name = "Romania" },
                    new Country() { Id = 141, Name = "Russian Federation" },
                    new Country() { Id = 142, Name = "Rwanda" },
                    new Country() { Id = 143, Name = "Saint Kitts and Nevis" },
                    new Country() { Id = 144, Name = "Saint Lucia" },
                    new Country() { Id = 145, Name = "Saint Vincent and the Grenadines" },
                    new Country() { Id = 146, Name = "Samoa" },
                    new Country() { Id = 147, Name = "San Marino" },
                    new Country() { Id = 148, Name = "Sao Tome and Principe" },
                    new Country() { Id = 149, Name = "Saudi Arabia" },
                    new Country() { Id = 150, Name = "Senegal" },
                    new Country() { Id = 151, Name = "Serbia" },
                    new Country() { Id = 152, Name = "Seychelles" },
                    new Country() { Id = 153, Name = "Sierra Leone" },
                    new Country() { Id = 154, Name = "Singapore" },
                    new Country() { Id = 155, Name = "Slovakia" },
                    new Country() { Id = 156, Name = "Slovenia" },
                    new Country() { Id = 157, Name = "Solomon Islands" },
                    new Country() { Id = 158, Name = "Somalia" },
                    new Country() { Id = 159, Name = "South Africa" },
                    new Country() { Id = 160, Name = "South Sudan" },
                    new Country() { Id = 161, Name = "Spain" },
                    new Country() { Id = 162, Name = "Sri Lanka" },
                    new Country() { Id = 163, Name = "Sudan" },
                    new Country() { Id = 164, Name = "Suriname" },
                    new Country() { Id = 165, Name = "Swaziland" },
                    new Country() { Id = 166, Name = "Sweden" },
                    new Country() { Id = 167, Name = "Switzerland" },
                    new Country() { Id = 168, Name = "Syrian Arab Republic" },
                    new Country() { Id = 169, Name = "Tajikistan" },
                    new Country() { Id = 170, Name = "Thailand" },
                    new Country() { Id = 171, Name = "The former Yugoslav Republic of Macedonia" },
                    new Country() { Id = 172, Name = "Timor-Leste" },
                    new Country() { Id = 173, Name = "Togo" },
                    new Country() { Id = 174, Name = "Tonga" },
                    new Country() { Id = 175, Name = "Trinidad and Tobago" },
                    new Country() { Id = 176, Name = "Tunisia" },
                    new Country() { Id = 177, Name = "Turkey" },
                    new Country() { Id = 178, Name = "Turkmenistan" },
                    new Country() { Id = 179, Name = "Tuvalu" },
                    new Country() { Id = 180, Name = "Uganda" },
                    new Country() { Id = 181, Name = "Ukraine" },
                    new Country() { Id = 182, Name = "United Arab Emirates" },
                    new Country() { Id = 183, Name = "United Kingdom of Great Britain and Northern Ireland" },
                    new Country() { Id = 184, Name = "United Republic of Tanzania" },
                    new Country() { Id = 185, Name = "United States of America" },
                    new Country() { Id = 186, Name = "Uruguay" },
                    new Country() { Id = 187, Name = "Uzbekistan" },
                    new Country() { Id = 188, Name = "Vanuatu" },
                    new Country() { Id = 189, Name = "Venezuela (Bolivarian Republic of)" },
                    new Country() { Id = 190, Name = "Viet Nam" },
                    new Country() { Id = 191, Name = "Yemen" },
                    new Country() { Id = 192, Name = "Zambia" },
                    new Country() { Id = 193, Name = "Zimbabwe" }
                );
            });

            modelBuilder.Entity<State>(s =>
            {
                s.HasData(
                    new State() { Id = 1, Name = "Alabama", CountryId = 185 },
                    new State() { Id = 2, Name = "Alaska", CountryId = 185 },
                    new State() { Id = 3, Name = "Arizona", CountryId = 185 },
                    new State() { Id = 4, Name = "Arkansas", CountryId = 185 },
                    new State() { Id = 5, Name = "California", CountryId = 185 },
                    new State() { Id = 6, Name = "Colorado", CountryId = 185 },
                    new State() { Id = 7, Name = "Connecticut", CountryId = 185 },
                    new State() { Id = 8, Name = "Delaware", CountryId = 185 },
                    new State() { Id = 9, Name = "District Of Columbia", CountryId = 185 },
                    new State() { Id = 10, Name = "Florida", CountryId = 185 },
                    new State() { Id = 11, Name = "Georgia", CountryId = 185 },
                    new State() { Id = 12, Name = "Hawaii", CountryId = 185 },
                    new State() { Id = 13, Name = "Idaho", CountryId = 185 },
                    new State() { Id = 14, Name = "Illinois", CountryId = 185 },
                    new State() { Id = 15, Name = "Indiana", CountryId = 185 },
                    new State() { Id = 16, Name = "Iowa", CountryId = 185 },
                    new State() { Id = 17, Name = "Kansas", CountryId = 185 },
                    new State() { Id = 18, Name = "Kentucky", CountryId = 185 },
                    new State() { Id = 19, Name = "Louisiana", CountryId = 185 },
                    new State() { Id = 20, Name = "Maine", CountryId = 185 },
                    new State() { Id = 21, Name = "Maryland", CountryId = 185 },
                    new State() { Id = 22, Name = "Massachusetts", CountryId = 185 },
                    new State() { Id = 23, Name = "Michigan", CountryId = 185 },
                    new State() { Id = 24, Name = "Minnesota", CountryId = 185 },
                    new State() { Id = 25, Name = "Mississippi", CountryId = 185 },
                    new State() { Id = 26, Name = "Missouri", CountryId = 185 },
                    new State() { Id = 27, Name = "Montana", CountryId = 185 },
                    new State() { Id = 28, Name = "Nebraska", CountryId = 185 },
                    new State() { Id = 29, Name = "Nevada", CountryId = 185 },
                    new State() { Id = 30, Name = "New Hampshire", CountryId = 185 },
                    new State() { Id = 31, Name = "New Jersey", CountryId = 185 },
                    new State() { Id = 32, Name = "New Mexico", CountryId = 185 },
                    new State() { Id = 33, Name = "New York", CountryId = 185 },
                    new State() { Id = 34, Name = "North Carolina", CountryId = 185 },
                    new State() { Id = 35, Name = "North Dakota", CountryId = 185 },
                    new State() { Id = 36, Name = "Ohio", CountryId = 185 },
                    new State() { Id = 37, Name = "Oklahoma", CountryId = 185 },
                    new State() { Id = 38, Name = "Oregon", CountryId = 185 },
                    new State() { Id = 39, Name = "Pennsylvania", CountryId = 185 },
                    new State() { Id = 40, Name = "Rhode Island", CountryId = 185 },
                    new State() { Id = 41, Name = "South Carolina", CountryId = 185 },
                    new State() { Id = 42, Name = "South Dakota", CountryId = 185 },
                    new State() { Id = 43, Name = "Tennessee", CountryId = 185 },
                    new State() { Id = 44, Name = "Texas", CountryId = 185 },
                    new State() { Id = 45, Name = "Utah", CountryId = 185 },
                    new State() { Id = 46, Name = "Vermont", CountryId = 185 },
                    new State() { Id = 47, Name = "Virginia", CountryId = 185 },
                    new State() { Id = 48, Name = "Washington", CountryId = 185 },
                    new State() { Id = 49, Name = "West Virginia", CountryId = 185 },
                    new State() { Id = 50, Name = "Wisconsin", CountryId = 185 },
                    new State() { Id = 51, Name = "Wyoming", CountryId = 185 },
                    new State() { Id = 52, Name = "Alberta", CountryId = 31 },
                    new State() { Id = 53, Name = "British Columbia", CountryId = 31 },
                    new State() { Id = 54, Name = "Manitoba", CountryId = 31 },
                    new State() { Id = 55, Name = "New Brunswick", CountryId = 31 },
                    new State() { Id = 56, Name = "Newfoundland and Labrador", CountryId = 31 },
                    new State() { Id = 57, Name = "Nova Scotia", CountryId = 31 },
                    new State() { Id = 58, Name = "Northwest Territories", CountryId = 31 },
                    new State() { Id = 59, Name = "Nunavut", CountryId = 31 },
                    new State() { Id = 60, Name = "Ontario", CountryId = 31 },
                    new State() { Id = 61, Name = "Prince Edward Island", CountryId = 31 },
                    new State() { Id = 62, Name = "Quebec", CountryId = 31 },
                    new State() { Id = 63, Name = "Saskatchewan", CountryId = 31 },
                    new State() { Id = 64, Name = "Yukon", CountryId = 31 }
                );
            });

            base.OnModelCreating(modelBuilder);
        }

    }
}
