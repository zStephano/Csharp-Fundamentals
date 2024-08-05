using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Given a list of numbers, return a list of all triplets that sum to a given value.
/// Dada uma lista de números, retorne uma lista de todos os trigêmeos que somam um determinado valor.
/// </summary>
/// <param name="numberList">A lista de número para validar os trigêmeos</param>
/// <param name="sum">O valor da soma esperada</param>
/// <returns>Lista dos trigêmeos</returns>
/// 
/// <example>
/// <code>
/// 

IEnumerable<int> numberList = new List<int> { 0, -1, 2, -3, 1 };
int sum = -2;
var result = GetTripletsEqualingSum(numberList, sum);

// // Resultado esperado: [(0, -3, 1), (-1, 2, -3)]
/// </code>
/// </example>
static IEnumerable<(int, int, int)> GetTripletsEqualingSum(IEnumerable<int> numberList, int sum)
{
    // Instancio a lista de resultados
    var result = new List<(int, int, int)>();

    // Instancio uma variável recebendo o numberList como Lista ao invés de IEnumerable 
    var numbers = numberList.ToList();

    // Instancio uma variável que irá contabilzar o total de posições na lista Number
    int n = numbers.Count();

    // Primeiro laço de repetição para pegar a punúltima posição do NumberList;
    for (int i = 0; i < n - 2; i++)
    {
        // Segundo laço de repetição para pegar a última posição do NumberList;
        for (int j = i + 1; j < n - 1; j++)
        {
            // Terceiro laço de repetição para pegar a última posição do NumberList;
            for (int k = j + 1; k < n; k++)
            {
                // Aqui irá validar se de acordo com cada posição de cada lista (I, J e K) irão retornar a soma do número desejado (no caso: -2)
                if (numbers[i] + numbers[j] + numbers[k] == sum)
                {
                    // Se sim, armazena o conjunto dos números que retornarm a soma
                    result.Add((numbers[i], numbers[j], numbers[k]));
                }
            }
        }
    }

    // Retorna o resultado das somas obtidas
    return result;
}
