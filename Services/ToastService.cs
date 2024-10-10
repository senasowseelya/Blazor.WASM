﻿using Blazor.WASM.Common;
using MudBlazor;

namespace Blazor.WASM.Services
{
    public class ToastService
    {
        private readonly ISnackbar _snackBarService;

        public ToastService(ISnackbar snackBar)
        {
            _snackBarService = snackBar;
        }

        public void ShowSuccess(string message)
        {
            _snackBarService.Add(
                message: ToastMessage(Constants.Success, message),
                severity: Severity.Success);
        }

        public void ShowInfo(string message)
        {
            _snackBarService.Add(
                message: ToastMessage(Constants.Info, message),
                severity: Severity.Info);
        }

        public void ShowWarning(string message)
        {
            _snackBarService.Add(
                message: ToastMessage(Constants.Warning, message),
                severity: Severity.Warning);

        }

        public void ShowError(string message)
        {
            _snackBarService.Add(
                message: ToastMessage(Constants.Error, message),
                severity: Severity.Error);

        }
        private static string ToastMessage(string title, string message) => $"<ul><li><strong>{title}<strong></li><li>{message}</li></ul>";
    }
}
