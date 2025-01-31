﻿using Ecosystem.Shared.Entitities.ViewModels.TrainningManager.Enumerables;
using Ecosystem.Shared.Entitities.ViewModels.TrainningManager;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecosystem.Shared.Entitities.ViewModels.TrainningManager
{
    public class VideoViewModel : IViewModel
    {
        public Guid Id { get; set; }
        public DateTimeOffset CreatedAt { get; set; }

        [MaxLength(100)]
        public string Name { get; set; }

        [MaxLength(512)]
        public string Url { get; set; }

        public BodyArea Area { get; set; }

        public TrainningGoal VideoGoal { get; set; }


        public bool EquipmentRequired { get; set; }

        public long DurationInSeconds { get; set; }

        public AuthorViewModel? Author { get; set; }
    }
}
