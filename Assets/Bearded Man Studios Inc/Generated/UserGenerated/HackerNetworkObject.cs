using BeardedManStudios.Forge.Networking.Frame;
using BeardedManStudios.Forge.Networking.Unity;
using System;
using UnityEngine;

namespace BeardedManStudios.Forge.Networking.Generated
{
	[GeneratedInterpol("{\"inter\":[0,0,0,0,0,0,0,0,0,0]")]
	public partial class HackerNetworkObject : NetworkObject
	{
		public const int IDENTITY = 4;

		private byte[] _dirtyFields = new byte[2];

		#pragma warning disable 0067
		public event FieldChangedEvent fieldAltered;
		#pragma warning restore 0067
		private float _LifeCoin;
		public event FieldEvent<float> LifeCoinChanged;
		public InterpolateFloat LifeCoinInterpolation = new InterpolateFloat() { LerpT = 0f, Enabled = false };
		public float LifeCoin
		{
			get { return _LifeCoin; }
			set
			{
				// Don't do anything if the value is the same
				if (_LifeCoin == value)
					return;

				// Mark the field as dirty for the network to transmit
				_dirtyFields[0] |= 0x1;
				_LifeCoin = value;
				hasDirtyFields = true;
			}
		}

		public void SetLifeCoinDirty()
		{
			_dirtyFields[0] |= 0x1;
			hasDirtyFields = true;
		}

		private void RunChange_LifeCoin(ulong timestep)
		{
			if (LifeCoinChanged != null) LifeCoinChanged(_LifeCoin, timestep);
			if (fieldAltered != null) fieldAltered("LifeCoin", _LifeCoin, timestep);
		}
		private float _RAM;
		public event FieldEvent<float> RAMChanged;
		public InterpolateFloat RAMInterpolation = new InterpolateFloat() { LerpT = 0f, Enabled = false };
		public float RAM
		{
			get { return _RAM; }
			set
			{
				// Don't do anything if the value is the same
				if (_RAM == value)
					return;

				// Mark the field as dirty for the network to transmit
				_dirtyFields[0] |= 0x2;
				_RAM = value;
				hasDirtyFields = true;
			}
		}

		public void SetRAMDirty()
		{
			_dirtyFields[0] |= 0x2;
			hasDirtyFields = true;
		}

		private void RunChange_RAM(ulong timestep)
		{
			if (RAMChanged != null) RAMChanged(_RAM, timestep);
			if (fieldAltered != null) fieldAltered("RAM", _RAM, timestep);
		}
		private float _CPU;
		public event FieldEvent<float> CPUChanged;
		public InterpolateFloat CPUInterpolation = new InterpolateFloat() { LerpT = 0f, Enabled = false };
		public float CPU
		{
			get { return _CPU; }
			set
			{
				// Don't do anything if the value is the same
				if (_CPU == value)
					return;

				// Mark the field as dirty for the network to transmit
				_dirtyFields[0] |= 0x4;
				_CPU = value;
				hasDirtyFields = true;
			}
		}

		public void SetCPUDirty()
		{
			_dirtyFields[0] |= 0x4;
			hasDirtyFields = true;
		}

		private void RunChange_CPU(ulong timestep)
		{
			if (CPUChanged != null) CPUChanged(_CPU, timestep);
			if (fieldAltered != null) fieldAltered("CPU", _CPU, timestep);
		}
		private float _Firewall;
		public event FieldEvent<float> FirewallChanged;
		public InterpolateFloat FirewallInterpolation = new InterpolateFloat() { LerpT = 0f, Enabled = false };
		public float Firewall
		{
			get { return _Firewall; }
			set
			{
				// Don't do anything if the value is the same
				if (_Firewall == value)
					return;

				// Mark the field as dirty for the network to transmit
				_dirtyFields[0] |= 0x8;
				_Firewall = value;
				hasDirtyFields = true;
			}
		}

		public void SetFirewallDirty()
		{
			_dirtyFields[0] |= 0x8;
			hasDirtyFields = true;
		}

		private void RunChange_Firewall(ulong timestep)
		{
			if (FirewallChanged != null) FirewallChanged(_Firewall, timestep);
			if (fieldAltered != null) fieldAltered("Firewall", _Firewall, timestep);
		}
		private bool _Breached;
		public event FieldEvent<bool> BreachedChanged;
		public Interpolated<bool> BreachedInterpolation = new Interpolated<bool>() { LerpT = 0f, Enabled = false };
		public bool Breached
		{
			get { return _Breached; }
			set
			{
				// Don't do anything if the value is the same
				if (_Breached == value)
					return;

				// Mark the field as dirty for the network to transmit
				_dirtyFields[0] |= 0x10;
				_Breached = value;
				hasDirtyFields = true;
			}
		}

		public void SetBreachedDirty()
		{
			_dirtyFields[0] |= 0x10;
			hasDirtyFields = true;
		}

		private void RunChange_Breached(ulong timestep)
		{
			if (BreachedChanged != null) BreachedChanged(_Breached, timestep);
			if (fieldAltered != null) fieldAltered("Breached", _Breached, timestep);
		}
		private bool _Online;
		public event FieldEvent<bool> OnlineChanged;
		public Interpolated<bool> OnlineInterpolation = new Interpolated<bool>() { LerpT = 0f, Enabled = false };
		public bool Online
		{
			get { return _Online; }
			set
			{
				// Don't do anything if the value is the same
				if (_Online == value)
					return;

				// Mark the field as dirty for the network to transmit
				_dirtyFields[0] |= 0x20;
				_Online = value;
				hasDirtyFields = true;
			}
		}

		public void SetOnlineDirty()
		{
			_dirtyFields[0] |= 0x20;
			hasDirtyFields = true;
		}

		private void RunChange_Online(ulong timestep)
		{
			if (OnlineChanged != null) OnlineChanged(_Online, timestep);
			if (fieldAltered != null) fieldAltered("Online", _Online, timestep);
		}
		private bool _Scanning;
		public event FieldEvent<bool> ScanningChanged;
		public Interpolated<bool> ScanningInterpolation = new Interpolated<bool>() { LerpT = 0f, Enabled = false };
		public bool Scanning
		{
			get { return _Scanning; }
			set
			{
				// Don't do anything if the value is the same
				if (_Scanning == value)
					return;

				// Mark the field as dirty for the network to transmit
				_dirtyFields[0] |= 0x40;
				_Scanning = value;
				hasDirtyFields = true;
			}
		}

		public void SetScanningDirty()
		{
			_dirtyFields[0] |= 0x40;
			hasDirtyFields = true;
		}

		private void RunChange_Scanning(ulong timestep)
		{
			if (ScanningChanged != null) ScanningChanged(_Scanning, timestep);
			if (fieldAltered != null) fieldAltered("Scanning", _Scanning, timestep);
		}
		private int _CPULvl;
		public event FieldEvent<int> CPULvlChanged;
		public Interpolated<int> CPULvlInterpolation = new Interpolated<int>() { LerpT = 0f, Enabled = false };
		public int CPULvl
		{
			get { return _CPULvl; }
			set
			{
				// Don't do anything if the value is the same
				if (_CPULvl == value)
					return;

				// Mark the field as dirty for the network to transmit
				_dirtyFields[0] |= 0x80;
				_CPULvl = value;
				hasDirtyFields = true;
			}
		}

		public void SetCPULvlDirty()
		{
			_dirtyFields[0] |= 0x80;
			hasDirtyFields = true;
		}

		private void RunChange_CPULvl(ulong timestep)
		{
			if (CPULvlChanged != null) CPULvlChanged(_CPULvl, timestep);
			if (fieldAltered != null) fieldAltered("CPULvl", _CPULvl, timestep);
		}
		private int _RAMLvl;
		public event FieldEvent<int> RAMLvlChanged;
		public Interpolated<int> RAMLvlInterpolation = new Interpolated<int>() { LerpT = 0f, Enabled = false };
		public int RAMLvl
		{
			get { return _RAMLvl; }
			set
			{
				// Don't do anything if the value is the same
				if (_RAMLvl == value)
					return;

				// Mark the field as dirty for the network to transmit
				_dirtyFields[1] |= 0x1;
				_RAMLvl = value;
				hasDirtyFields = true;
			}
		}

		public void SetRAMLvlDirty()
		{
			_dirtyFields[1] |= 0x1;
			hasDirtyFields = true;
		}

		private void RunChange_RAMLvl(ulong timestep)
		{
			if (RAMLvlChanged != null) RAMLvlChanged(_RAMLvl, timestep);
			if (fieldAltered != null) fieldAltered("RAMLvl", _RAMLvl, timestep);
		}
		private int _FirewallLvl;
		public event FieldEvent<int> FirewallLvlChanged;
		public Interpolated<int> FirewallLvlInterpolation = new Interpolated<int>() { LerpT = 0f, Enabled = false };
		public int FirewallLvl
		{
			get { return _FirewallLvl; }
			set
			{
				// Don't do anything if the value is the same
				if (_FirewallLvl == value)
					return;

				// Mark the field as dirty for the network to transmit
				_dirtyFields[1] |= 0x2;
				_FirewallLvl = value;
				hasDirtyFields = true;
			}
		}

		public void SetFirewallLvlDirty()
		{
			_dirtyFields[1] |= 0x2;
			hasDirtyFields = true;
		}

		private void RunChange_FirewallLvl(ulong timestep)
		{
			if (FirewallLvlChanged != null) FirewallLvlChanged(_FirewallLvl, timestep);
			if (fieldAltered != null) fieldAltered("FirewallLvl", _FirewallLvl, timestep);
		}

		protected override void OwnershipChanged()
		{
			base.OwnershipChanged();
			SnapInterpolations();
		}
		
		public void SnapInterpolations()
		{
			LifeCoinInterpolation.current = LifeCoinInterpolation.target;
			RAMInterpolation.current = RAMInterpolation.target;
			CPUInterpolation.current = CPUInterpolation.target;
			FirewallInterpolation.current = FirewallInterpolation.target;
			BreachedInterpolation.current = BreachedInterpolation.target;
			OnlineInterpolation.current = OnlineInterpolation.target;
			ScanningInterpolation.current = ScanningInterpolation.target;
			CPULvlInterpolation.current = CPULvlInterpolation.target;
			RAMLvlInterpolation.current = RAMLvlInterpolation.target;
			FirewallLvlInterpolation.current = FirewallLvlInterpolation.target;
		}

		public override int UniqueIdentity { get { return IDENTITY; } }

		protected override BMSByte WritePayload(BMSByte data)
		{
			UnityObjectMapper.Instance.MapBytes(data, _LifeCoin);
			UnityObjectMapper.Instance.MapBytes(data, _RAM);
			UnityObjectMapper.Instance.MapBytes(data, _CPU);
			UnityObjectMapper.Instance.MapBytes(data, _Firewall);
			UnityObjectMapper.Instance.MapBytes(data, _Breached);
			UnityObjectMapper.Instance.MapBytes(data, _Online);
			UnityObjectMapper.Instance.MapBytes(data, _Scanning);
			UnityObjectMapper.Instance.MapBytes(data, _CPULvl);
			UnityObjectMapper.Instance.MapBytes(data, _RAMLvl);
			UnityObjectMapper.Instance.MapBytes(data, _FirewallLvl);

			return data;
		}

		protected override void ReadPayload(BMSByte payload, ulong timestep)
		{
			_LifeCoin = UnityObjectMapper.Instance.Map<float>(payload);
			LifeCoinInterpolation.current = _LifeCoin;
			LifeCoinInterpolation.target = _LifeCoin;
			RunChange_LifeCoin(timestep);
			_RAM = UnityObjectMapper.Instance.Map<float>(payload);
			RAMInterpolation.current = _RAM;
			RAMInterpolation.target = _RAM;
			RunChange_RAM(timestep);
			_CPU = UnityObjectMapper.Instance.Map<float>(payload);
			CPUInterpolation.current = _CPU;
			CPUInterpolation.target = _CPU;
			RunChange_CPU(timestep);
			_Firewall = UnityObjectMapper.Instance.Map<float>(payload);
			FirewallInterpolation.current = _Firewall;
			FirewallInterpolation.target = _Firewall;
			RunChange_Firewall(timestep);
			_Breached = UnityObjectMapper.Instance.Map<bool>(payload);
			BreachedInterpolation.current = _Breached;
			BreachedInterpolation.target = _Breached;
			RunChange_Breached(timestep);
			_Online = UnityObjectMapper.Instance.Map<bool>(payload);
			OnlineInterpolation.current = _Online;
			OnlineInterpolation.target = _Online;
			RunChange_Online(timestep);
			_Scanning = UnityObjectMapper.Instance.Map<bool>(payload);
			ScanningInterpolation.current = _Scanning;
			ScanningInterpolation.target = _Scanning;
			RunChange_Scanning(timestep);
			_CPULvl = UnityObjectMapper.Instance.Map<int>(payload);
			CPULvlInterpolation.current = _CPULvl;
			CPULvlInterpolation.target = _CPULvl;
			RunChange_CPULvl(timestep);
			_RAMLvl = UnityObjectMapper.Instance.Map<int>(payload);
			RAMLvlInterpolation.current = _RAMLvl;
			RAMLvlInterpolation.target = _RAMLvl;
			RunChange_RAMLvl(timestep);
			_FirewallLvl = UnityObjectMapper.Instance.Map<int>(payload);
			FirewallLvlInterpolation.current = _FirewallLvl;
			FirewallLvlInterpolation.target = _FirewallLvl;
			RunChange_FirewallLvl(timestep);
		}

		protected override BMSByte SerializeDirtyFields()
		{
			dirtyFieldsData.Clear();
			dirtyFieldsData.Append(_dirtyFields);

			if ((0x1 & _dirtyFields[0]) != 0)
				UnityObjectMapper.Instance.MapBytes(dirtyFieldsData, _LifeCoin);
			if ((0x2 & _dirtyFields[0]) != 0)
				UnityObjectMapper.Instance.MapBytes(dirtyFieldsData, _RAM);
			if ((0x4 & _dirtyFields[0]) != 0)
				UnityObjectMapper.Instance.MapBytes(dirtyFieldsData, _CPU);
			if ((0x8 & _dirtyFields[0]) != 0)
				UnityObjectMapper.Instance.MapBytes(dirtyFieldsData, _Firewall);
			if ((0x10 & _dirtyFields[0]) != 0)
				UnityObjectMapper.Instance.MapBytes(dirtyFieldsData, _Breached);
			if ((0x20 & _dirtyFields[0]) != 0)
				UnityObjectMapper.Instance.MapBytes(dirtyFieldsData, _Online);
			if ((0x40 & _dirtyFields[0]) != 0)
				UnityObjectMapper.Instance.MapBytes(dirtyFieldsData, _Scanning);
			if ((0x80 & _dirtyFields[0]) != 0)
				UnityObjectMapper.Instance.MapBytes(dirtyFieldsData, _CPULvl);
			if ((0x1 & _dirtyFields[1]) != 0)
				UnityObjectMapper.Instance.MapBytes(dirtyFieldsData, _RAMLvl);
			if ((0x2 & _dirtyFields[1]) != 0)
				UnityObjectMapper.Instance.MapBytes(dirtyFieldsData, _FirewallLvl);

			// Reset all the dirty fields
			for (int i = 0; i < _dirtyFields.Length; i++)
				_dirtyFields[i] = 0;

			return dirtyFieldsData;
		}

		protected override void ReadDirtyFields(BMSByte data, ulong timestep)
		{
			if (readDirtyFlags == null)
				Initialize();

			Buffer.BlockCopy(data.byteArr, data.StartIndex(), readDirtyFlags, 0, readDirtyFlags.Length);
			data.MoveStartIndex(readDirtyFlags.Length);

			if ((0x1 & readDirtyFlags[0]) != 0)
			{
				if (LifeCoinInterpolation.Enabled)
				{
					LifeCoinInterpolation.target = UnityObjectMapper.Instance.Map<float>(data);
					LifeCoinInterpolation.Timestep = timestep;
				}
				else
				{
					_LifeCoin = UnityObjectMapper.Instance.Map<float>(data);
					RunChange_LifeCoin(timestep);
				}
			}
			if ((0x2 & readDirtyFlags[0]) != 0)
			{
				if (RAMInterpolation.Enabled)
				{
					RAMInterpolation.target = UnityObjectMapper.Instance.Map<float>(data);
					RAMInterpolation.Timestep = timestep;
				}
				else
				{
					_RAM = UnityObjectMapper.Instance.Map<float>(data);
					RunChange_RAM(timestep);
				}
			}
			if ((0x4 & readDirtyFlags[0]) != 0)
			{
				if (CPUInterpolation.Enabled)
				{
					CPUInterpolation.target = UnityObjectMapper.Instance.Map<float>(data);
					CPUInterpolation.Timestep = timestep;
				}
				else
				{
					_CPU = UnityObjectMapper.Instance.Map<float>(data);
					RunChange_CPU(timestep);
				}
			}
			if ((0x8 & readDirtyFlags[0]) != 0)
			{
				if (FirewallInterpolation.Enabled)
				{
					FirewallInterpolation.target = UnityObjectMapper.Instance.Map<float>(data);
					FirewallInterpolation.Timestep = timestep;
				}
				else
				{
					_Firewall = UnityObjectMapper.Instance.Map<float>(data);
					RunChange_Firewall(timestep);
				}
			}
			if ((0x10 & readDirtyFlags[0]) != 0)
			{
				if (BreachedInterpolation.Enabled)
				{
					BreachedInterpolation.target = UnityObjectMapper.Instance.Map<bool>(data);
					BreachedInterpolation.Timestep = timestep;
				}
				else
				{
					_Breached = UnityObjectMapper.Instance.Map<bool>(data);
					RunChange_Breached(timestep);
				}
			}
			if ((0x20 & readDirtyFlags[0]) != 0)
			{
				if (OnlineInterpolation.Enabled)
				{
					OnlineInterpolation.target = UnityObjectMapper.Instance.Map<bool>(data);
					OnlineInterpolation.Timestep = timestep;
				}
				else
				{
					_Online = UnityObjectMapper.Instance.Map<bool>(data);
					RunChange_Online(timestep);
				}
			}
			if ((0x40 & readDirtyFlags[0]) != 0)
			{
				if (ScanningInterpolation.Enabled)
				{
					ScanningInterpolation.target = UnityObjectMapper.Instance.Map<bool>(data);
					ScanningInterpolation.Timestep = timestep;
				}
				else
				{
					_Scanning = UnityObjectMapper.Instance.Map<bool>(data);
					RunChange_Scanning(timestep);
				}
			}
			if ((0x80 & readDirtyFlags[0]) != 0)
			{
				if (CPULvlInterpolation.Enabled)
				{
					CPULvlInterpolation.target = UnityObjectMapper.Instance.Map<int>(data);
					CPULvlInterpolation.Timestep = timestep;
				}
				else
				{
					_CPULvl = UnityObjectMapper.Instance.Map<int>(data);
					RunChange_CPULvl(timestep);
				}
			}
			if ((0x1 & readDirtyFlags[1]) != 0)
			{
				if (RAMLvlInterpolation.Enabled)
				{
					RAMLvlInterpolation.target = UnityObjectMapper.Instance.Map<int>(data);
					RAMLvlInterpolation.Timestep = timestep;
				}
				else
				{
					_RAMLvl = UnityObjectMapper.Instance.Map<int>(data);
					RunChange_RAMLvl(timestep);
				}
			}
			if ((0x2 & readDirtyFlags[1]) != 0)
			{
				if (FirewallLvlInterpolation.Enabled)
				{
					FirewallLvlInterpolation.target = UnityObjectMapper.Instance.Map<int>(data);
					FirewallLvlInterpolation.Timestep = timestep;
				}
				else
				{
					_FirewallLvl = UnityObjectMapper.Instance.Map<int>(data);
					RunChange_FirewallLvl(timestep);
				}
			}
		}

		public override void InterpolateUpdate()
		{
			if (IsOwner)
				return;

			if (LifeCoinInterpolation.Enabled && !LifeCoinInterpolation.current.UnityNear(LifeCoinInterpolation.target, 0.0015f))
			{
				_LifeCoin = (float)LifeCoinInterpolation.Interpolate();
				//RunChange_LifeCoin(LifeCoinInterpolation.Timestep);
			}
			if (RAMInterpolation.Enabled && !RAMInterpolation.current.UnityNear(RAMInterpolation.target, 0.0015f))
			{
				_RAM = (float)RAMInterpolation.Interpolate();
				//RunChange_RAM(RAMInterpolation.Timestep);
			}
			if (CPUInterpolation.Enabled && !CPUInterpolation.current.UnityNear(CPUInterpolation.target, 0.0015f))
			{
				_CPU = (float)CPUInterpolation.Interpolate();
				//RunChange_CPU(CPUInterpolation.Timestep);
			}
			if (FirewallInterpolation.Enabled && !FirewallInterpolation.current.UnityNear(FirewallInterpolation.target, 0.0015f))
			{
				_Firewall = (float)FirewallInterpolation.Interpolate();
				//RunChange_Firewall(FirewallInterpolation.Timestep);
			}
			if (BreachedInterpolation.Enabled && !BreachedInterpolation.current.UnityNear(BreachedInterpolation.target, 0.0015f))
			{
				_Breached = (bool)BreachedInterpolation.Interpolate();
				//RunChange_Breached(BreachedInterpolation.Timestep);
			}
			if (OnlineInterpolation.Enabled && !OnlineInterpolation.current.UnityNear(OnlineInterpolation.target, 0.0015f))
			{
				_Online = (bool)OnlineInterpolation.Interpolate();
				//RunChange_Online(OnlineInterpolation.Timestep);
			}
			if (ScanningInterpolation.Enabled && !ScanningInterpolation.current.UnityNear(ScanningInterpolation.target, 0.0015f))
			{
				_Scanning = (bool)ScanningInterpolation.Interpolate();
				//RunChange_Scanning(ScanningInterpolation.Timestep);
			}
			if (CPULvlInterpolation.Enabled && !CPULvlInterpolation.current.UnityNear(CPULvlInterpolation.target, 0.0015f))
			{
				_CPULvl = (int)CPULvlInterpolation.Interpolate();
				//RunChange_CPULvl(CPULvlInterpolation.Timestep);
			}
			if (RAMLvlInterpolation.Enabled && !RAMLvlInterpolation.current.UnityNear(RAMLvlInterpolation.target, 0.0015f))
			{
				_RAMLvl = (int)RAMLvlInterpolation.Interpolate();
				//RunChange_RAMLvl(RAMLvlInterpolation.Timestep);
			}
			if (FirewallLvlInterpolation.Enabled && !FirewallLvlInterpolation.current.UnityNear(FirewallLvlInterpolation.target, 0.0015f))
			{
				_FirewallLvl = (int)FirewallLvlInterpolation.Interpolate();
				//RunChange_FirewallLvl(FirewallLvlInterpolation.Timestep);
			}
		}

		private void Initialize()
		{
			if (readDirtyFlags == null)
				readDirtyFlags = new byte[2];

		}

		public HackerNetworkObject() : base() { Initialize(); }
		public HackerNetworkObject(NetWorker networker, INetworkBehavior networkBehavior = null, int createCode = 0, byte[] metadata = null) : base(networker, networkBehavior, createCode, metadata) { Initialize(); }
		public HackerNetworkObject(NetWorker networker, uint serverId, FrameStream frame) : base(networker, serverId, frame) { Initialize(); }

		// DO NOT TOUCH, THIS GETS GENERATED PLEASE EXTEND THIS CLASS IF YOU WISH TO HAVE CUSTOM CODE ADDITIONS
	}
}
