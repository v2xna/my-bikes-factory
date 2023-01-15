using MyBikesFactory.Business.Enums; // have access to enums
using System.Xml.Serialization; // for data and for xmlinclude
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBikesFactory.Business
{
    [Serializable]
    [XmlInclude(typeof(MountainBike))]
    [XmlInclude(typeof(RoadBike))]

    public abstract class Bike
    {
        // Serial number(unique, number only),
        // Model (5 char, numbers or letters only),
        // Manufacturing year (4 char, number only).

        private int _serialNumber;
        private string _name;
        private string _model;
        private int _manufacturingYear;
        private EColor _color;

        public int SerialNumber { get => _serialNumber; set => _serialNumber = value; }
        public string Name { get => _name; set => _name = value; }
        public string Model { get => _model; set => _model = value; }
        public int ManufacturingYear { get => _manufacturingYear; set => _manufacturingYear = value; }
        public EColor Color { get => _color; set => _color = value; }

        public Bike()
        {
            _serialNumber = 0;
            _name = "";
            _model = "";
            _manufacturingYear = 0;
            _color = EColor.Undefined;
        }

        public Bike(int initialSerialNumber) : this()
        {
            _serialNumber = initialSerialNumber;
        }

        public override string ToString()
        {
            return $"Serial number: {_serialNumber}, Name: {_name}, Model: {_model}, Manufacturing year: {_manufacturingYear}, Color: {_color}";
        }
    }
}
