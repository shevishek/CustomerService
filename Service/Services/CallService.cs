using Common.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Services
{
    public class CallService
    {
    //    //תמלול השיחה וחלוקה ללקוח וטלפנית
    //    public async Task totext()
    //    {
    //        config.SpeechRecognitionLanguage = "he-IL";
    //        config.SetProperty(
    //            "ConversationTranscriptionInRoomAndOnline",
    //            "true");

    //        using var audioConfig = AudioConfig.FromWavFileInput("test5.wav");
    //        using var transcriber = new ConversationTranscriber(config, audioConfig);

    //        var segments = new List<Segment>();

    //        transcriber.Transcribed += (s, e) =>
    //        {
    //            if (e.Result.Reason == ResultReason.RecognizedSpeech)
    //            {
    //                var segment = new Segment
    //                {
    //                    SpeakerId = e.Result.SpeakerId,
    //                    Text = e.Result.Text,
    //                    Start = TimeSpan.FromTicks(e.Result.OffsetInTicks),
    //                    Duration = e.Result.Duration
    //                };

    //                segments.Add(segment);

    //                // DEBUG – לראות בזמן אמת
    //                Console.WriteLine(
    //                    $"{segment.SpeakerId}: {segment.Text}");
    //            }
    //        };

    //        await transcriber.StartTranscribingAsync();
    //        await Task.Delay(TimeSpan.FromSeconds(30));
    //        await transcriber.StopTranscribingAsync();

    //        //התוצאה המתומללת
    //        var speakerTexts = segments
    //    .GroupBy(s => s.SpeakerId)
    //    .ToDictionary(
    //        g => g.Key,
    //        g => string.Join(" ", g.Select(x => x.Text))
    //    );

    //        foreach (var speaker in speakerTexts)
    //        {
    //            Console.WriteLine($"---- {speaker.Key} ----");
    //            Console.WriteLine(speaker.Value);
    //            Console.WriteLine();
    //        }


    //        AudioSplitter.CreateSpeakerWav(
    //"test5.wav",
    //segments,
    //"Guest-1",
    //"agent.wav");

    //        AudioSplitter.CreateSpeakerWav(
    //            "test5.wav",
    //            segments,
    //            "Guest-2",
    //            "customer.wav");
    //    }


        


    //    //קבלת הניתוח של השיחה - חיובי שלילי או ניטרלי
    //    public async Task get()
    //    {

    //        if (speakerTexts.TryGetValue("Guest-1", out var speakerText))
    //        {
    //            var sentiment = textAnalyzer.AnalyzeSentiment(speakerText);

    //            Console.WriteLine($"*Sentiment: {sentiment.Sentiment}");
    //            Console.WriteLine($"*Confidence Positive: {sentiment.Positive:0.00}");
    //            Console.WriteLine($"*Confidence Neutral: {sentiment.Neutral:0.00}");
    //            Console.WriteLine($"*Confidence Negative: {sentiment.Negative:0.00}");
    //        }
    //        else
    //        {
    //            Console.WriteLine("Speaker-0 לא נמצא בתמלול");
    //        }
    //    }


    //    //קבלת ציון כללי לשיחה
    //    public async Task allscore()
    //    {

    //    }

    //    //האם טלפנית או לקוח על פי משפט ראשון בשיחה
    //    public async Task agentoroperator()
    //    {

    //    }

    }
}
