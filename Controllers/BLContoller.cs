using Microsoft.AspNetCore.Mvc;

namespace tp2.Controllers
{
    public ActionResult GetRelatorio()
    {
        object db = null;
        var bls = db.BLs.Include(b => b.Containers).ToList();
        return Views(bls);
    }

    ActionResult Views(object bls)
    {
        throw new NotImplementedException();
    }

    ActionResult View(object bls)
    {
        throw new NotImplementedException();
    }
}
