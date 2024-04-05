namespace AppAvaliacoes.Services;

public class SampleDataService
{
	public async Task<IEnumerable<SampleItem>> GetItems(string materia)
	{
		await Task.Delay(1); // Artifical delay to give the impression of work

		var random = new Random().Next();

		var result = new List<SampleItem>();

		ComandosCRUD c = new ComandosCRUD();

		using(SqlDataReader reader = c.readerAulas(materia))
		{
            while (reader.Read())
            {
                result.Add(new SampleItem
                {
                    IdAula = (int)reader[0],
                    Data = (DateTime)reader[1],
                    Professor = (string)reader[2],
                    Descricao = (string)reader[3]
                });
            }
        }
		
		return result;
	}
}
