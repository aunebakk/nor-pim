using DotNet.Highcharts;
using DotNet.Highcharts.Enums;
using DotNet.Highcharts.Helpers;
using DotNet.Highcharts.Options;
using HighlightsChart.Models;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using norpim.BusinessLogicLayer;
using norpim.mvc.Controllers;
using System;

// https://csharptrenches.wordpress.com/2013/08/21/how-to-use-highcharts-js-with-asp-net-mvc-4/

namespace HighlightsChart.Controllers {
    public class ChartController : Controller {
        public ActionResult Index() {
            Logging.ActionLog(Request, "Chart Index ( ASP MVC WCF )" );

            ProductStatisticsContract[] statistics = new StatisticsSearchService().ProductStatistics();
            
            //create a collection of data
            var transactionCounts = new List<TransactionCount>();

            foreach (ProductStatisticsContract contract in statistics.Reverse()) { 
                transactionCounts.Add(
                    new TransactionCount() {  
                        Day=contract.ActivityDate.Substring(3, 5), 
                        Count=contract.DayCount
                        }
                    );
            }

            //modify data type to make it of array type
            var xDataMonths = transactionCounts.Select(i => i.Day).ToArray();
            var yDataCounts = transactionCounts.Select(i => new object[] { i.Count }).ToArray();

            //instantiate an object of the High charts type
            var chart = new Highcharts("chart")
            //define the type of chart 
            .InitChart(new Chart { DefaultSeriesType = ChartTypes.Line })
            //overall Title of the chart 
            .SetTitle(new Title { Text = "nor-pim" })
            //small label below the main Title
            .SetSubtitle(new Subtitle { Text = "User Activities" })
            //load the X values
            .SetXAxis(new XAxis { Categories = xDataMonths })
            //set the Y title
            .SetYAxis(new YAxis { Title = new YAxisTitle { Text = "Number of Transactions" } })
            .SetTooltip(new Tooltip {
                Enabled = true,
                Formatter = @"function() { return '<b>'+ this.series.name +'</b><br/>'+ this.x +': '+ this.y; }"
            })
            .SetPlotOptions(new PlotOptions {
                Line = new PlotOptionsLine {
                    DataLabels = new PlotOptionsLineDataLabels {
                        Enabled = true
                    },
                    EnableMouseTracking = false
                }
            })
                //load the Y values 
                        .SetSeries(new[]
                    {
                        new Series {Name = "Transactions", Data = new Data(yDataCounts)},
                            //you can add more y data to create a second line
                            // new Series { Name = "Other Name", Data = new Data(OtherData) }
                    });


            return View(chart);
        }

    }
}
