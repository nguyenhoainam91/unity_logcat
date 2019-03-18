using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class UnityLogCat{

    public static string LOG_TAG = "TAG";

    public static void debug(string log)
    {
        Debug.Log("<color=navy><b>" +  LOG_TAG + ":</b> " + log + "</color>");
    }

    public static void d(string log)
    {
        UnityLogCat.debug(log);
    }

    public static void info(string log)
    {
        Debug.Log("<color=green><b>" + LOG_TAG + ":</b> " + log + "</color>");
    }

    public static void i(string log)
    {
        UnityLogCat.info(log);
    }

    public static void verbose(string log)
    {
        Debug.Log("<color=grey><b>" + LOG_TAG + ":</b> " + log + "</color>");
    }

    public static void v(string log)
    {
        UnityLogCat.verbose(log);
    }

    public static void warning(string log)
    {
        Debug.Log("<color=orange><b>" + LOG_TAG + ":</b> " + log + "</color>");
    }

    public static void w(string log)
    {
        UnityLogCat.warning(log);
    }

    public static void error(string log)
    {
        Debug.Log("<color=red><b>" + LOG_TAG + ":</b> " + log + "</color>");
    }

    public static void e(string log)
    {
        UnityLogCat.error(log);
    }

    public static void fatal(string log)
    {
        Debug.Log("<color=magenta ><b>" + LOG_TAG + ":</b> " + log + "</color>");
    }

    public static void f(string log)
    {
        UnityLogCat.fatal(log);
    }


}
