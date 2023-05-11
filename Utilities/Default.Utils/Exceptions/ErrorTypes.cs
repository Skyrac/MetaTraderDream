namespace Default.Utils.Exceptions;

public static class ErrorTypes
{
    public const string NO_USER = "no_user_found";
    public const string NO_TEMP_USER = "no_temp_user_found";
    public const string NO_WALLET = "no_wallet_found";
    public const string NOT_ENOUGH_VOTING_POWER = "not_enough_voting_power";
    public const string TOO_MANY_PROPOSALS = "too_many_proposals";
    public const string PROPOSAL_NOT_FOUND = "proposal_not_found";
    public const string ALREADY_VOTED_ON_PROPOSAL = "already_voted";
    public const string VOTING_NOT_OPEN = "voting_not_open";
    public const string CHAIN_NOT_SUPPORTED = "chain_not_supported";
    public const string CLAIM_AMOUNT_TOO_LOW = "claim_amount_too_low";
    public const string CANT_CLAIM_TODAY_AGAIN = "cant_claim_today_again";
    public const string LIVE_SESSION_NOT_FOUND = "live_session_not_found";
    public const string NOT_A_LIVE_SESSION_HOST = "not_a_live_session_host";
    public const string TOO_MANY_SESSIONS_AS_SUPERHOST = "too_many_sessions_as_superhost";
    public const string LIVE_SESSION_ROOM_ALREADY_EXIST = "live_session_room_exist";
    public const string CHAT_NOT_FOUND = "chat_not_found";
    public const string USER_NOT_IN_CHAT = "user_not_in_chat";
    public const string USER_NO_PERMISSION_FOR_CHAT = "user_no_permission_for_chat";
    public const string MESSAGE_TO_ANSWER_NOT_FOUND_IN_CHAT = "message_to_answer_not_found_in_chat";
    public const string EDIT_FAILED_MESSAGE_NOT_FOUND = "edit_failed_message_not_found";
    public const string USER_NO_PERMISSION_FOR_PODCAST = "user_no_permission_for_podcast";
    public const string PODCAST_NOT_FOUND = "podcast_not_found";
    public const string EPISODE_NOT_FOUND = "episode_not_found";
    public const string EPISODE_NOT_CONNECTED_TO_PODCAST = "episode_not_connected_to_podcast";
    public const string TOO_MANY_PODCASTS = "too_many_podcasts";
    public const string USER_ALREADY_HAS_NC_WALLET = "user_already_has_nc_wallet";
    public const string ONLY_SUPERHOST_CAN_ADD_NEW_HOST = "only_superhost_can_add_new_host";
    public const string SESSION_USER_IS_ALREADY_HOST = "session_user_is_already_a_host";
    public const string SESSION_USER_IS_NOT_A_HOST = "session_user_is_not_a_host";
    public const string ONLY_SUPERHOST_CAN_REMOVE_HOST = "only_superhost_can_remove_host";
}
