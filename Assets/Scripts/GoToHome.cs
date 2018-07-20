using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class GoToHome : MonoBehaviour {

    public GameObject displayImage;
    public GameObject Home;
    public GameObject Clear;
    public GameObject goBack;
    public Text display;
    public GameObject[] panels;
    public List<GameObject> panelList;
    public Text TypeText;
    public GameObject keyboardImage;
        
    //panels
    public GameObject SendToPanel;
    public GameObject HomePanel;
    public GameObject QuestionsPanel;
    public GameObject PeoplePanel;
    public GameObject ActionsPanel;
    public GameObject MoreActionsPanel;
    public GameObject DescribePanel;
    public GameObject MoreDescribePanel;
    public GameObject ThingsPanel;
    public GameObject WantPanel;
    public GameObject INeedPanel;
    public GameObject PlacesPanel;
    public GameObject FeelingsPanel;
    public GameObject ChatPanel;
    public GameObject JiboPanel;
    public GameObject ColorsPanel;
    public GameObject FoodPanel;
    public GameObject AnimalsPanel;
    public GameObject BodyPanel;
    public GameObject WeatherPanel;
    public GameObject WherePanel;
    public GameObject ClothingPanel;
    public GameObject KeyboardPanel;



    //Home buttons
    public GameObject Questions;
    public GameObject Things;
    public GameObject dontWant;
    public GameObject Actions;
    public GameObject homePeople;
    public GameObject want;
    public GameObject Describe;
    public GameObject need;
    public GameObject Places;
    public GameObject feel;
    public GameObject Chat;
    public GameObject Jibo;

    //Questions buttons
    public GameObject who;
    public GameObject what;
    public GameObject where;
    public GameObject when;
    public GameObject why;
    public GameObject how;
    public GameObject howMuch;
    public GameObject howLong;
    public GameObject whereGoing;
    public GameObject whatsUp;
    public GameObject whatDoing;
    public GameObject whatsHappen;

    //People buttons
    public GameObject Dad;
    public GameObject Mom;
    public GameObject People;
    public GameObject I;
    public GameObject me;
    public GameObject she;
    public GameObject he;
    public GameObject you;
    public GameObject and;

    //Actions buttons
    public GameObject buy;
    public GameObject call;
    public GameObject come;
    public GameObject cook;
    public GameObject drink;
    public GameObject eat;
    public GameObject give;
    public GameObject go;
    public GameObject help;
    public GameObject hurt;
    public GameObject jump;
    public GameObject like;
    public GameObject wear;
    public GameObject MoreActions;

    //MoreActions buttons
    public GameObject play;
    public GameObject read;
    public GameObject ride;
    public GameObject run;
    public GameObject sleep;
    public GameObject stop;
    public GameObject swing;
    public GameObject talk;
    public GameObject walk;
    public GameObject wantAction;
    public GameObject watch;
    public GameObject work;

    //Describe buttons
    public GameObject nice;
    public GameObject mean;
    public GameObject good;
    public GameObject describeBad;
    public GameObject big;
    public GameObject small;
    public GameObject favorite;
    public GameObject colors;
    public GameObject feelings;
    public GameObject weather;
    public GameObject whereQuestion;
    public GameObject moreDescribe;

    //Colors Buttons
    public GameObject blue;
    public GameObject black;
    public GameObject brown;
    public GameObject gray;
    public GameObject green;
    public GameObject orange;
    public GameObject pink;
    public GameObject purple;
    public GameObject red;
    public GameObject white;
    public GameObject yellow;

    //More Describe buttons

    //Things buttons
    public GameObject Food;
    public GameObject Animals;
    public GameObject body;

    //Where buttons
    public GameObject wherePlaces;

    //Want buttons
    public GameObject wantThings;
    public GameObject wantWear;

    //Need buttons
    public GameObject needThings;
    public GameObject needActions;

    //Places buttons

    //Feelings buttons
    public GameObject angry;
    public GameObject bad;
    public GameObject bored;
    public GameObject confused;
    public GameObject excited;
    public GameObject fine;
    public GameObject frustrated;
    public GameObject happy;
    public GameObject pain;
    public GameObject sad;
    public GameObject scared;
    public GameObject tired;

    //Chat buttons
    public GameObject Hello;
    public GameObject gmorn;
    public GameObject gnight;
    public GameObject howYou;
    public GameObject gbye;
    public GameObject whatName;
    public GameObject myName;
    public GameObject keyboard;

    //Jibo buttons
    public GameObject JiboLikes;
    public GameObject Jibofeels;
    public GameObject JiboAct;


    public void GoToHomeScreen()
    {
        displayImage.SetActive(true);
        Home.SetActive(false);
        Clear.SetActive(true);
        goBack.SetActive(false);
        keyboardImage.SetActive(false);
        TypeText.text = "";
        foreach (GameObject panel in panels)
        {
            if (panel.name != "HomePanel")
            {
                panel.SetActive(false);
            }
            HomePanel.SetActive(true);
        }
        
    }

    string panelName;
    GameObject whichPanel;
    
    public void GoTo()
    {
        Home.SetActive(true);
        goBack.SetActive(true);
        foreach (GameObject panel in panels)
        {
            if (panel.name != panelName)
            {
                panel.SetActive(false);
            }
            whichPanel.SetActive(true);
        }
    }

    public void MakeList()
    {
        panels = GameObject.FindGameObjectsWithTag("Panel");
        panelList.Add(panels[0]);
    }
    public void GoToLast()
    {
        lastPanel = panelList[panelList.Count-1];
        panelName = lastPanel.name;
        whichPanel = lastPanel;
        GoTo();
        panelList.RemoveAt(panelList.Count - 1);
    }

    public void GoToQuestions()
    {
        panelName = "QuestionsPanel";
        whichPanel = QuestionsPanel;
        GoTo();
        
    }

    public void GoToPeople()
    {
        panelName = "PeoplePanel";
        whichPanel = PeoplePanel;
        GoTo();
        
    }

    public void GoToActions()
    {
        panelName = "ActionsPanel";
        whichPanel = ActionsPanel;
        GoTo();
        
    }

    public void GoToMoreActions()
    {
        panelName = "MoreActionsPanel";
        whichPanel = MoreActionsPanel;
        GoTo();
        

    }

    public void GoToDescribe()
    {
        panelName = "DescribePanel";
        whichPanel = DescribePanel;
        GoTo();

    }

    public void GoToMoreDescribe()
    {
        panelName = "MoreDescribePanel";
        whichPanel = MoreDescribePanel;
        GoTo();
        
    }
    
    public void GoToThings()
    {
        panelName = "ThingsPanel";
        whichPanel = ThingsPanel;
        GoTo();
        
    }

    public void GoToWants()
    {
        panelName = "WantPanel";
        whichPanel = WantPanel;
        GoTo();
        
    }

    public void GoToNeeds()
    {
        panelName = "INeedPanel";
        whichPanel = INeedPanel;
        GoTo();
        
    }

    public void GoToPlaces()
    {
        panelName = "PlacesPanel";
        whichPanel = PlacesPanel;
        GoTo();
        
    }

    public void GoToFeelings()
    {
        panelName = "FeelingsPanel";
        whichPanel = FeelingsPanel;
        GoTo();
        
    }

    public void GoToChat()
    {
        panelName = "ChatPanel";
        whichPanel = ChatPanel;
        GoTo();
    }
    
    public void GoToJibo()
    {
        panelName = "JiboPanel";
        whichPanel = JiboPanel;
        GoTo();
        
    }

    public void GoToColors()
    {
        panelName = "ColorsPanel";
        whichPanel = ColorsPanel;
        GoTo();
        
    }

    public void GoToFood()
    {
        panelName = "FoodPanel";
        whichPanel = FoodPanel;
        GoTo();
        
    }

    public void GoToAnimals()
    {
        panelName = "AnimalsPanel";
        whichPanel = AnimalsPanel;
        GoTo();
        
    }

    public void GoToBody()
    {
        panelName = "BodyPanel";
        whichPanel = BodyPanel;
        GoTo();
        
    }

    public void GoToWeather()
    {
        panelName = "WeatherPanel";
        whichPanel = WeatherPanel;
        GoTo();
        
    }

    public void GoToWhere()
    {
        panelName = "WherePanel";
        whichPanel = WherePanel;
        GoTo();
        
    }

    public void GoToClothing()
    {
        panelName = "ClothingPanel";
        whichPanel = ClothingPanel;
        GoTo();
    }

    public void GoToKeyboard()
    {
        panelName = "KeyboardPanel";
        whichPanel = KeyboardPanel;
        GoTo();
    }


    public void BackToHome()
    {
        if (Input.anyKey && EventSystem.current.currentSelectedGameObject.tag == "toHome")
        {

            GoToHomeScreen();
        }
    }

    GameObject lastPanel;

    public void HomeButtons() {
        Button q = Questions.GetComponent<Button>();
        Button w = want.GetComponent<Button>();
        Button dw = dontWant.GetComponent<Button>();
        Button a = Actions.GetComponent<Button>();
        Button hp = homePeople.GetComponent<Button>();
        Button d = Describe.GetComponent<Button>();
        Button t = Things.GetComponent<Button>();
        Button n = need.GetComponent<Button>();
        Button pl = Places.GetComponent<Button>();
        Button f = feel.GetComponent<Button>();
        Button c = Chat.GetComponent<Button>();
        Button j = Jibo.GetComponent<Button>();
        q.onClick.AddListener(GoToQuestions);
        w.onClick.AddListener(GoToWants);
        dw.onClick.AddListener(GoToWants);
        a.onClick.AddListener(GoToActions);
        hp.onClick.AddListener(GoToPeople);
        d.onClick.AddListener(GoToDescribe);
        t.onClick.AddListener(GoToThings);
        n.onClick.AddListener(GoToNeeds);
        pl.onClick.AddListener(GoToPlaces);
        f.onClick.AddListener(GoToFeelings);
        c.onClick.AddListener(GoToChat);
        j.onClick.AddListener(GoToJibo);
        
    }

    public void OtherButtons()
    {
        Button co = colors.GetComponent<Button>();
        Button nt = needThings.GetComponent<Button>();
        Button fe = feelings.GetComponent<Button>();
        Button feels = Jibofeels.GetComponent<Button>();
        Button act = JiboAct.GetComponent<Button>();
        Button wt = wantThings.GetComponent<Button>();
        Button na = needActions.GetComponent<Button>();
        Button fo = Food.GetComponent<Button>();
        Button an = Animals.GetComponent<Button>();
        Button b = body.GetComponent<Button>();
        Button ma = MoreActions.GetComponent<Button>();
        Button md = moreDescribe.GetComponent<Button>();
        Button w = weather.GetComponent<Button>();
        Button wh = whereQuestion.GetComponent<Button>();
        Button p = wherePlaces.GetComponent<Button>();
        Button k = keyboard.GetComponent<Button>();
        Button we = wear.GetComponent<Button>();
        Button ww = wantWear.GetComponent<Button>();
        co.onClick.AddListener(GoToColors);
        nt.onClick.AddListener(GoToThings);
        fe.onClick.AddListener(GoToFeelings);
        feels.onClick.AddListener(GoToFeelings);
        act.onClick.AddListener(GoToActions);
        wt.onClick.AddListener(GoToThings);
        na.onClick.AddListener(GoToActions);
        fo.onClick.AddListener(GoToFood);
        an.onClick.AddListener(GoToAnimals);
        b.onClick.AddListener(GoToBody);
        ma.onClick.AddListener(GoToMoreActions);
        md.onClick.AddListener(GoToMoreDescribe);
        w.onClick.AddListener(GoToWeather);
        wh.onClick.AddListener(GoToWhere);
        p.onClick.AddListener(GoToPlaces);
        k.onClick.AddListener(GoToKeyboard);
        we.onClick.AddListener(GoToClothing);
        ww.onClick.AddListener(GoToClothing);
    }
    
    void Start()
        {
            panels = GameObject.FindGameObjectsWithTag("Panel");
            display.text = "";
            TypeText.text = "";
            keyboardImage.SetActive(false);
            displayImage.SetActive(false);
            Home.SetActive(false);
            Clear.SetActive(false);
            goBack.SetActive(false);
            foreach (GameObject panel in panels)
            {
                panel.SetActive(false);
            }
                SendToPanel.SetActive(true);
            
        }

	
	// Update is called once per frame
	void Update () {
        panels = GameObject.FindGameObjectsWithTag("Panel");
        HomeButtons();
        OtherButtons();
        BackToHome();
    }

}
