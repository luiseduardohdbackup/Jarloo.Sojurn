﻿using System;
using Caliburn.Micro;

namespace Jarloo.Sojurn.Models
{
    public class TimeLineItem : PropertyChangedBase
    {
        private Show show;
        private Episode episode;

        public DateTime? Date
        {
            get { return episode.AirDate; }
        }

        public Episode Episode
        {
            get { return episode; }
            set
            {
                episode = value;
                NotifyOfPropertyChange(() => Episode);
                NotifyOfPropertyChange(() => Date);
            }
        }

        public Show Show
        {
            get { return show; }
            set
            {
                show = value;
                NotifyOfPropertyChange(() => Show);
            }
        }
    }
}