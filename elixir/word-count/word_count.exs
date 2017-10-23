defmodule Words do
  @doc """
  Count the number of words in the sentence.

  Words are compared case-insensitively.
  """
  @spec count(String.t) :: map
  def count(sentence) do
    sentence
    |> String.replace(~r/[^äöüßÄÖÜa-zA-Z\s0-9\-\_]*/, "")
    |> String.replace(~r/[\s\s|\_]/, " ")
    |> String.downcase
    |> String.split
    |> Enum.reduce(%{}, fn(word, acc) ->
         Map.merge(acc, %{word => 1}, fn(_k, v1, _v2) -> v1 + 1 end)
       end)
  end
end
