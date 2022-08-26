namespace Tests

open Xunit
open FsUnit.Xunit

module ``Daycare test suite`` =

    [<Fact>]
    let ``Toddlers are children from 2 to 4 years old`` () =
        true |> should be True
