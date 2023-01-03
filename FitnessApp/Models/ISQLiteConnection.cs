using System;
using SQLite;

namespace FitnessApp.Models
{
	public interface ISQLiteConnection
	{
        SQLiteConnection GetConnection();
    }
}

