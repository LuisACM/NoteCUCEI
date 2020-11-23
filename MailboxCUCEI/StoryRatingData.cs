using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.ML.Data;

namespace MailboxCUCEI
{
    public class StoryRating
    {
        [LoadColumn(0)]
        public float userId;
        [LoadColumn(1)]
        public float storyId;
        [LoadColumn(2)]
        public float Label;
    }
    public class StoryRatingPrediction
    {
        public float Label;
        public float Score;
    }
}
