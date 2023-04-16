// See https://aka.ms/new-console-template for more information
using Sayan_SentimentAnalysis;

//Console.WriteLine("Hello, World!");

//Load sample data


//Load model and predict output
Console.Write("Enter Review: ");
var review = Console.ReadLine();
var sampleData = new SentimentModel.ModelInput()
{
    Col0 = $"{review}",
};
var result = SentimentModel.Predict(sampleData);
string finalResult = result.PredictedLabel == 0 ? "Negative" : "Positive";
Console.WriteLine($"Sentiment: {finalResult.ToString()}");