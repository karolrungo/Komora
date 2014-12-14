using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Moq;
using Komora;

namespace Komora.Test.DataTypes
{
    [TestFixture]
    public class MeasurementSamplesTests
    {
        private Komora.DataTypes.MeasurementSamples<double> measurementSamples;

        [Test]
        public void canCreateEmptySampleObject()
        {
            measurementSamples = new Komora.DataTypes.MeasurementSamples<double>();
        }

        [Test]
        public void canInitializeMeasurementSampleWithMeasurementsamplesObject()
        {
            measurementSamples = new Komora.DataTypes.MeasurementSamples<double>(new Komora.DataTypes.MeasurementSamples<double>());
        }

        [Test]
        public void canInitializeMeasurementSampleWithTupleListObject()
        {
            measurementSamples = new Komora.DataTypes.MeasurementSamples<double>(new List<Tuple<double, double>>(10));
        }

        [Test]
        public void canInitializeMeasurementSamplesWithTwoDoubleLists()
        { 
            List<double> x = new List<double>(){1.0, 2.0, 4.5};
            List<double> y = new List<double>(){7.0, 5.3, 2.1};
            measurementSamples = new Komora.DataTypes.MeasurementSamples<double>(x, y);
            
            var result = new List<Tuple<double,double>>() {
                                                          new Tuple<double,double>(1.0, 7.0),
                                                          new Tuple<double,double>(2.0, 5.3),
                                                          new Tuple<double,double>(4.5, 2.1)
                                                          };

            Assert.AreEqual(result.Count, measurementSamples.samples.Count);
            Assert.AreEqual(result, measurementSamples.samples);
        }

        [Test]
        public void getCountReturnsProperValue()
        {
            measurementSamples = new Komora.DataTypes.MeasurementSamples<double> (new List<Tuple<double,double>> 
                                                               {
                                                                   new Tuple<double,double>(1.0, 7.0),
                                                                   new Tuple<double,double>(2.0, 5.3),
                                                                   new Tuple<double,double>(4.5, 2.1)
                                                               });
            Assert.AreEqual(3, measurementSamples.samples.Count);
        }
    }
}
