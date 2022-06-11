using _1.Interfaces;
using _1.Models;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Xml;

namespace _1.Share
{
    public class XmlDocumentWorker : IXmlWorker
    {
        private readonly XmlDocument _document;
        private readonly ILogger _logger;
        private string _xmlFilePath;
        public XmlDocumentWorker(ILogger logger)
        {
            _logger = logger;
            _document = new XmlDocument();
        }
        public void Add(Airport airport)
        {
            var xRoot = _document.DocumentElement;
            XmlElement airportElem = _document.CreateElement("airport");

            XmlAttribute destinationAttribute = _document.CreateAttribute("destination");
            XmlText destinationText = _document.CreateTextNode(airport.destination);
            destinationAttribute.AppendChild(destinationText);

            XmlElement flightElem = _document.CreateElement("flight");
            XmlText flightInnerText = _document.CreateTextNode(airport.flight.ToString());
            flightElem.AppendChild(flightInnerText);

            airportElem.AppendChild(flightElem);

            XmlElement timeElem = _document.CreateElement("time");
            XmlText timeInnerText = _document.CreateTextNode(airport.time);
            timeElem.AppendChild(timeInnerText);

            airportElem.AppendChild(timeElem);

            xRoot.AppendChild(airportElem);
            _document.Save(_xmlFilePath);
        }
        public void Delete(string destination)
        {
            var xRoot = _document.DocumentElement;
            foreach(XmlNode xNode in xRoot)
            {
                if(xNode.Attributes.Count > 0)
                {
                    var attributeDestination = xNode.Attributes.GetNamedItem("destination");
                    try
                    {
                        var attributeDestinationText = attributeDestination?.InnerText;
                        if(attributeDestinationText.Equals(destination))
                        {
                            xRoot.RemoveChild(xNode);
                        }
                    }
                    catch(Exception ex) when (ex is XmlException || ex is NullReferenceException)
                    {
                        _logger.LogWarning(ex.Message, nameof(attributeDestination));
                    }
                }
            }
        }
        public Airport FindBy(string destination)
        {
            Airport airport = null;
            var xRoot = _document.DocumentElement;
            foreach (XmlNode xNode in xRoot)
            {
                airport = GetAirport(xNode);
                if(airport.destination.Equals(destination))
                {
                    return airport;
                }
            }
            return airport;
        }
        public List<Airport> GetAll()
        {
            List<Airport> airports = new List<Airport>();
            var xRoot = _document.DocumentElement;
            foreach (XmlNode xNode in xRoot)
            {
                var airport = GetAirport(xNode);
                airports.Add(airport);
            }
            return airports;
        }
        public void Load(string xmlFilePath)
        {
            _xmlFilePath = xmlFilePath;
            _document.Load(xmlFilePath);
        }
        private Airport GetAirport(XmlNode node)
        {
            var airport = new Airport();
            if(node.Attributes.Count > 0)
            {
                var attributeDestination = node.Attributes.GetNamedItem("destination");
                airport.destination = attributeDestination?.Value;
            }
            foreach (XmlNode childNode in node.ChildNodes)
            {
                try
                {
                    if (childNode.Name.Equals("destination"))
                    {
                        airport.destination = childNode.InnerText;
                    }
                    if (childNode.Name.Equals("flight"))
                    {
                        airport.flight = int.Parse(childNode.InnerText);
                    }
                    if (childNode.Name.Equals("time"))
                    {
                        airport.time = childNode.InnerText;
                    }
                }
                catch(Exception ex) when (ex is FormatException || ex is NullReferenceException)
                {
                    _logger.LogError(ex.Message, ex.StackTrace, nameof(childNode.InnerText));
                }
            }
            return airport;
        }
    }
}
