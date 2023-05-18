// Bad Code
abstract class AdapterBase {
    protected string Name;

    public string GetName() {
        return Name;
    }
}

class AjaxAdapter : AdapterBase {
    public AjaxAdapter() {
        Name = "ajaxAdapter";
    }
}

class NodeAdapter : AdapterBase {
    public NodeAdapter() {
        Name = "nodeAdapter";
    }
}

class HttpRequester : AdapterBase{
    private readonly AdapterBase Adapter;

    public HttpRequester(AdapterBase adapter){
        Adapter = adapter;
    }

    public bool Fetch(string url){
        var adapterName = Adapter.GetName();

        if (adapterName == "ajaxAdapter")
        {
            return MakeAjaxCall(url);
        }
        else if (adapterName == "httpNodeAdapter")
        {
            return MakeHttpCall(url);
        }
    }

    private bool MakeAjaxCall(string url)
    {
        // request and return promise
    }

    private bool MakeHttpCall(string url)
    {
        // request and return promise
    }
}