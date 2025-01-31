﻿using Ecosystem.Shared.Entitities;
using Ecosystem.Shared.Entitities.ViewModels.TrainningManager;
using Ecosystem.Shared.Entitities.ViewModels.TrainningManager.Enumerables;
using System.ComponentModel.DataAnnotations;

namespace Ecosystem.Shared.ViewModels.TrainningManager
{
    public class PlanViewModel : IViewModel
    {
        [Required]
        public string Name { get; set; }
        public long Duration { get; set; }
        public Guid Id { get; set; }
        public DateTimeOffset CreatedAt { get; set; }
        public BodyArea BodyAreas { get; set; }
        public TrainningGoal TrainningGoal { get; set; }
        public ICollection<VideoViewModel>? Videos { get; set; }
    }
}
