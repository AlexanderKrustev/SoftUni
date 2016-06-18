package States;


public  class StateManager {
    private static State currentState;

    public static void setCurrent(State newState){
        currentState=newState;
    }

    public static State getCurrentState(){
        return currentState;
    }
}
