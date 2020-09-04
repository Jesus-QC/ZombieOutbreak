using Exiled.API.Features;
using ZombieOutbreak.Handlers;

namespace ZombieOutbreak
{
    public class ZombieOutbreak : Plugin<Config>
    {
        private EventHandlers EventHandlers;

        public override string Name { get; } = "ZombieOutbreak";
        public override string Author { get; } = "JesusQC";
        public override string Prefix { get; } = "ZombieOutbreak";

        public override void OnEnabled()
        {
            base.OnEnabled();

            RegisterEvents();
        }

        public override void OnDisabled()
        {
            base.OnDisabled();

            UnregisterEvents();
        }

        public void RegisterEvents()
        {
            EventHandlers = new EventHandlers(this);

            Exiled.Events.Handlers.Server.RoundStarted += EventHandlers.OnRoundStarted;
        }

        public void UnregisterEvents()
        {
            Exiled.Events.Handlers.Server.RoundStarted -= EventHandlers.OnRoundStarted;

            EventHandlers = null;
        }
    }
}