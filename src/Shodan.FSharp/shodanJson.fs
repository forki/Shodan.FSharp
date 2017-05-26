namespace Shodan.FSharp

open FSharp.Data

module JsonResponse =
    
    [<AutoOpen>]
    module private Paths =

        [<Literal>]
        let JsonFolder = __SOURCE_DIRECTORY__ + "/../../json"

        [<Literal>]
        let ErrorJson = JsonFolder + "/error.json"

        [<Literal>]
        let ApiInfoJson = JsonFolder + "/apiInfo.json"

        [<Literal>]
        let AccountInfoJson = JsonFolder + "/accountInfo.json"

        [<Literal>]
        let HttpHeadersJson = JsonFolder + "/httpheaders.json"

        [<Literal>]
        let Honeyscore = JsonFolder + "/labs/honeyscore.json"

        module Search =

            [<Literal>]
            let SearchJson = JsonFolder + "/search/search.json"

            [<Literal>]
            let HostInfoJson = JsonFolder + "/search/host.json"

            [<Literal>]
            let PortsJson = JsonFolder + "/search/ports.json"

            [<Literal>]
            let CountJson = JsonFolder + "/search/count.json"

            [<Literal>]
            let TokensJson = JsonFolder + "/search/tokens.json"

        module Scan =

            [<Literal>]
            let ScanJson = JsonFolder + "/scan/scan.json"

            [<Literal>]
            let InternetJson = JsonFolder + "/scan/internet.json"

            [<Literal>]
            let ProcotolsJson = JsonFolder + "/scan/protocols.json"

            [<Literal>]
            let ScanIdJson = JsonFolder + "/scan/scanId.json"

        module DNS =
            
            [<Literal>]
            let ReverseJson = JsonFolder + "/dns/reverse.json"

            [<Literal>]
            let ResolveJson = JsonFolder + "/dns/resolve.json"
            

    type ErrorJson = JsonProvider<ErrorJson>

    type ApiInfoJson = JsonProvider<ApiInfoJson, ResolutionFolder=JsonFolder>
   
    type AccountInfoJson = JsonProvider<AccountInfoJson, ResolutionFolder=JsonFolder>
   
    module Scan =

        type ScanJson = JsonProvider<Scan.ScanJson>

        type ProtocolsJson = JsonProvider<Scan.ProcotolsJson>

        type ScanIdJson = JsonProvider<Scan.ScanIdJson>

        type InternetJson = JsonProvider<Scan.InternetJson>

    module Search =

        type CountJson = JsonProvider<Search.CountJson>

        type SearchJson = JsonProvider<Search.SearchJson>

        type HostInfoJson = JsonProvider<Search.HostInfoJson>

        type TokensJson = JsonProvider<Search.TokensJson>

        type PortsJson = JsonProvider<Search.PortsJson>

    module DNS =

        type ResolveJson = JsonProvider<DNS.ResolveJson, true>

        type ReverseJson = JsonProvider<DNS.ReverseJson, true>
    
        