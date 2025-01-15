using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitDiary.Models;

public sealed class AppModel
{

    public SessionModel SelectedSession { get; set; }
    public List<SessionModel> Sessions { get; set; } = new List<SessionModel>();

    public static AppModel Instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = new AppModel();
            }
            return _instance;
        }
    }

    private static AppModel _instance;

    public AppModel()
    {
        
    }
}

