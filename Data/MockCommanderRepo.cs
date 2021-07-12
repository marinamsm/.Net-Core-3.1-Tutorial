using System;
using System.Collections.Generic;
using Commander.Models;

namespace Commander.Data 
{
    public class MockCommanderRepo : ICommanderRepo
    {
        private List<Command> commands = new List<Command>();
        public void CreateCommand(Command cmd)
        {
            cmd.Id = commands.Count;
            commands.Add(cmd);

            // var list = commands.FindAll(command => command.Id >= 0);
            commands.ForEach(command => Console.WriteLine("id: {0}", command.Id));
            Console.WriteLine("id: {0}, howTo: {1}, line: {2}, platform: {3}", cmd.Id, cmd.HowTo, cmd.Line, cmd.Platform);
        }

        public void DeleteCommand(Command cmd)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Command> GetAllCommands()
        {
            return commands;
        }

        public Command GetCommandById(int id)
        {
            var command = commands.Find(cmd => cmd.Id == id);
            
            return command;
        }

        public bool SaveChanges()
        {
            return true;
        }

        public void UpdateCommand(Command cmd)
        {
            throw new NotImplementedException();
        }
    }
}