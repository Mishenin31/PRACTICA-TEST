using System.Windows.Input;
namespace TestExpert.WPF.Helpers;
public class RelayCommand : ICommand { private readonly Action<object?> _e; private readonly Predicate<object?>? _c; public RelayCommand(Action<object?> e, Predicate<object?>? c=null){_e=e;_c=c;} public bool CanExecute(object? p)=>_c?.Invoke(p)??true; public void Execute(object? p)=>_e(p); public event EventHandler? CanExecuteChanged{add=>CommandManager.RequerySuggested+=value;remove=>CommandManager.RequerySuggested-=value;} }
