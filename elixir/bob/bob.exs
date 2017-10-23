defmodule Bob do
  def hey(input) do
    scrubbed_input = String.replace(input, ~r/[ ,]/, "" )
    cond do
      # Empty String
      Regex.match?(~r/^$/, scrubbed_input) -> "Fine. Be that way!"

      # Ends with Question Mark
      Regex.match?(~r/\?$/, scrubbed_input) -> "Sure."

      # Ends with Period
      Regex.match?(~r/\.$/, scrubbed_input) -> "Whatever."

      # Contains only Numbers
      Regex.match?(~r/^\d+$/, scrubbed_input) -> "Whatever."

      # Contains only Caps
      Regex.match?(~r/^[^a-z]*$/, scrubbed_input) -> "Whoa, chill out!"

      true -> "Whatever."
  end
end
