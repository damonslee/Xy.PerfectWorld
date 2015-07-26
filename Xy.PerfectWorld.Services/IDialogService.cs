﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xy.PerfectWorld.Services
{
    public interface IDialogService
    {
        void DisplayExceptionOn<TViewModel>(TViewModel typeProvider, Exception e) where TViewModel : class;
        void DisplayExceptionOn<TViewModel>(Exception e) where TViewModel : class;
        Task<DialogResult> ShowMessageDialogOnAsync<TViewModel>(string title, string message,
            string affirmativeButtonText = null,
            string negativeButtonText = null,
            string firstAuxiliaryButtonText = null,
            string secondAuxiliaryButtonText = null) where TViewModel : class;
    }

    public enum DialogResult
    {
        Negative = 0,
        Affirmative = 1,
        FirstAuxiliary = 2,
        SecondAuxiliary = 3
    }
}
