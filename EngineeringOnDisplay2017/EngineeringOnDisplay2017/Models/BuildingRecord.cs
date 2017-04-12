﻿/****************************************************************************************************************
 * Project: Engineering on Display
 * Purpose: Website for displaying sensor data from the Engineering and Industry Building at the University of
 *          Alaska, Anchorage.  First features is a front end website for the general users to view
 *          the graphical data of the sensors and read more on the purpose of the display.  Second Feature
 *          is a admin secured website to add more slideshows to the third feature and view statistics. The third feature
 *          is a slide show of different advertisements.  
 * 
 * Authors:  Martin Boyle
 *           Terrance Mount
 *           Andrew Smart
 *           
 * Sponsor: Dr. Kenrick Mock
 * 
 * Instructor: Dr. Martin Cenek
 * 
 * Class:  CSCE 470 Capstone  Spring 2017
 * College: University of Alaska, Anchorage
 * ***********************************************************************************************************************
 * File: BuildingRecord.cs
 * Purpose: Keep the record of a single building (row in table)
 * 
 *  Puedo-Code:
 *      Properties for:
 *          Record id - primary key
 *          Name of building
 *          Acronym of building - most likely what the website will look up the building by.
 *          Many strings for address, city, state and zip
 * 
 * *******************************************************************************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EngineeringOnDisplay2017.Models
{

    /**
    * Model for storing a record (row in table) of building name and address.    
    */
    public class BuildingRecord
    {
        public int BuildingRecordId { get; set; }  //primary key, used unsigned byte because assuming to have less then 255 building in database
        public string Name { get; set; } //name of building  like Engineering and Industry Building
        public string Acronym { get; set; }  //the acronym commonly used by UAA EIB
        public string AddressLineOne { get; set; } //first line of address
        public string AddressLineTwo { get; set; } //second line of address, will not display if null
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
    }
}
