using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;


public class TeamMembers
{
	public string firstName { get; set; }
	public string lastName { get; set; }
	public string gender { get; set; }
	public int age { get; set; }
	public string nim { get; set; }
}

public class Team
{
	public List<TeamMembers> members { get; set; }
}

public class DataTeamMember_1201210018
{
	public void ReadJSON(string filePath2)
	{
		string jsonContent = File.ReadAllText(filePath2);

		Team team = JsonSerializer.Deserialize<Team>(jsonContent);

		Console.WriteLine("Team member list:");
		foreach (var member in team.members)
		{
			Console.WriteLine($"{member.nim} {member.firstName} {member.lastName} ({member.age} {member.gender})");
		}
	}
}