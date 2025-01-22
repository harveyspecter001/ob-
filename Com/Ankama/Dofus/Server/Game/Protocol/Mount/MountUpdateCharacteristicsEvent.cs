using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Com.Ankama.Dofus.Server.Game.Protocol.Common;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Mount
{
	// Token: 0x0200038D RID: 909
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class MountUpdateCharacteristicsEvent : IMessage<MountUpdateCharacteristicsEvent>, IMessage, IEquatable<MountUpdateCharacteristicsEvent>, IDeepCloneable<MountUpdateCharacteristicsEvent>, IBufferMessage
	{
		// Token: 0x17000797 RID: 1943
		// (get) Token: 0x06002A93 RID: 10899 RVA: 0x001C92BC File Offset: 0x001C74BC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<MountUpdateCharacteristicsEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17000798 RID: 1944
		// (get) Token: 0x06002A94 RID: 10900 RVA: 0x001C92CC File Offset: 0x001C74CC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17000799 RID: 1945
		// (get) Token: 0x06002A95 RID: 10901 RVA: 0x001C92DC File Offset: 0x001C74DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x06002A96 RID: 10902 RVA: 0x001C92EC File Offset: 0x001C74EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public MountUpdateCharacteristicsEvent()
		{
		}

		// Token: 0x06002A97 RID: 10903 RVA: 0x001C92FC File Offset: 0x001C74FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public MountUpdateCharacteristicsEvent(MountUpdateCharacteristicsEvent other)
		{
		}

		// Token: 0x06002A98 RID: 10904 RVA: 0x001C930C File Offset: 0x001C750C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public MountUpdateCharacteristicsEvent Clone()
		{
			return null;
		}

		// Token: 0x1700079A RID: 1946
		// (get) Token: 0x06002A99 RID: 10905 RVA: 0x001C931C File Offset: 0x001C751C
		// (set) Token: 0x06002A9A RID: 10906 RVA: 0x001C932C File Offset: 0x001C752C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int RideId
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return 0;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x1700079B RID: 1947
		// (get) Token: 0x06002A9B RID: 10907 RVA: 0x001C933C File Offset: 0x001C753C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<MountUpdateCharacteristicsEvent.Types.MountCharacteristicUpdate> UpdatedCharacteristics
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x06002A9C RID: 10908 RVA: 0x001C934C File Offset: 0x001C754C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06002A9D RID: 10909 RVA: 0x001C935C File Offset: 0x001C755C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(MountUpdateCharacteristicsEvent other)
		{
			return true;
		}

		// Token: 0x06002A9E RID: 10910 RVA: 0x001C936C File Offset: 0x001C756C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06002A9F RID: 10911 RVA: 0x001C937C File Offset: 0x001C757C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06002AA0 RID: 10912 RVA: 0x001C938C File Offset: 0x001C758C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06002AA1 RID: 10913 RVA: 0x001C939C File Offset: 0x001C759C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06002AA2 RID: 10914 RVA: 0x001C93AC File Offset: 0x001C75AC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06002AA3 RID: 10915 RVA: 0x001C93BC File Offset: 0x001C75BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(MountUpdateCharacteristicsEvent other)
		{
		}

		// Token: 0x06002AA4 RID: 10916 RVA: 0x001C93CC File Offset: 0x001C75CC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06002AA5 RID: 10917 RVA: 0x001C93DC File Offset: 0x001C75DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06002AA6 RID: 10918 RVA: 0x001C93EC File Offset: 0x001C75EC
		[MethodImpl(MethodImplOptions.NoInlining)]
		static MountUpdateCharacteristicsEvent()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 3;
			for (;;)
			{
				int num2 = num;
				for (;;)
				{
					switch (num2)
					{
					case 1:
						return;
					case 2:
						goto IL_BF;
					case 3:
						xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
						num2 = 2;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_edad103d99794972a048278f53152048 != 0)
						{
							num2 = 1;
							continue;
						}
						continue;
					case 4:
						goto IL_39;
					case 5:
						MountUpdateCharacteristicsEvent._parser = new MessageParser<MountUpdateCharacteristicsEvent>(() => null);
						num2 = 0;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_4b8749bf652542ac9b363b68e0ada0c3 != 0)
						{
							num2 = 0;
							continue;
						}
						continue;
					}
					MountUpdateCharacteristicsEvent._repeated_updatedCharacteristics_codec = FieldCodec.ForMessage<MountUpdateCharacteristicsEvent.Types.MountCharacteristicUpdate>(18U, jI4yGOnV45DK76dPwKZw.XVInXhlssT(jI4yGOnV45DK76dPwKZw.pJLnVjU5G60));
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_eb8096ad37114ad3a791519b69a785d5 == 0)
					{
						num2 = 1;
					}
				}
				IL_39:
				UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
				num = 5;
				continue;
				IL_BF:
				AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
				num = 4;
			}
		}

		// Token: 0x06002AA7 RID: 10919 RVA: 0x001C94FC File Offset: 0x001C76FC
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool dDYML3OrDDb56o0AitoS()
		{
			return true;
		}

		// Token: 0x06002AA8 RID: 10920 RVA: 0x001C9504 File Offset: 0x001C7704
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static MountUpdateCharacteristicsEvent ipM6leOrt5jpRHjXUEFf()
		{
			return null;
		}

		// Token: 0x04000F04 RID: 3844
		private static readonly MessageParser<MountUpdateCharacteristicsEvent> _parser;

		// Token: 0x04000F05 RID: 3845
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000F06 RID: 3846
		public const int RideIdFieldNumber = 1;

		// Token: 0x04000F07 RID: 3847
		private int rideId_;

		// Token: 0x04000F08 RID: 3848
		public const int UpdatedCharacteristicsFieldNumber = 2;

		// Token: 0x04000F09 RID: 3849
		private static readonly FieldCodec<MountUpdateCharacteristicsEvent.Types.MountCharacteristicUpdate> _repeated_updatedCharacteristics_codec;

		// Token: 0x04000F0A RID: 3850
		private readonly RepeatedField<MountUpdateCharacteristicsEvent.Types.MountCharacteristicUpdate> updatedCharacteristics_;

		// Token: 0x04000F0B RID: 3851
		internal static MountUpdateCharacteristicsEvent uGDdCAOrCZwcLtOLomiJ;

		// Token: 0x0200038E RID: 910
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static class Types
		{
			// Token: 0x06002AA9 RID: 10921 RVA: 0x002B9C1C File Offset: 0x002B7E1C
			[MethodImpl(MethodImplOptions.NoInlining)]
			static Types()
			{
				uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
				xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
			}

			// Token: 0x0200038F RID: 911
			[DebuggerDisplay("{ToString(),nq}")]
			public sealed class MountCharacteristicUpdate : IMessage<MountUpdateCharacteristicsEvent.Types.MountCharacteristicUpdate>, IMessage, IEquatable<MountUpdateCharacteristicsEvent.Types.MountCharacteristicUpdate>, IDeepCloneable<MountUpdateCharacteristicsEvent.Types.MountCharacteristicUpdate>, IBufferMessage
			{
				// Token: 0x1700079C RID: 1948
				// (get) Token: 0x06002AAA RID: 10922 RVA: 0x002FB408 File Offset: 0x002F9608
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public static MessageParser<MountUpdateCharacteristicsEvent.Types.MountCharacteristicUpdate> Parser
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					get
					{
						return null;
					}
				}

				// Token: 0x1700079D RID: 1949
				// (get) Token: 0x06002AAB RID: 10923 RVA: 0x002FB418 File Offset: 0x002F9618
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				public static MessageDescriptor Descriptor
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					get
					{
						return null;
					}
				}

				// Token: 0x1700079E RID: 1950
				// (get) Token: 0x06002AAC RID: 10924 RVA: 0x002FB428 File Offset: 0x002F9628
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				MessageDescriptor IMessage.Descriptor
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					get
					{
						return null;
					}
				}

				// Token: 0x06002AAD RID: 10925 RVA: 0x002FB438 File Offset: 0x002F9638
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public MountCharacteristicUpdate()
				{
				}

				// Token: 0x06002AAE RID: 10926 RVA: 0x002FB448 File Offset: 0x002F9648
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public MountCharacteristicUpdate(MountUpdateCharacteristicsEvent.Types.MountCharacteristicUpdate other)
				{
				}

				// Token: 0x06002AAF RID: 10927 RVA: 0x002FB458 File Offset: 0x002F9658
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public MountUpdateCharacteristicsEvent.Types.MountCharacteristicUpdate Clone()
				{
					return null;
				}

				// Token: 0x1700079F RID: 1951
				// (get) Token: 0x06002AB0 RID: 10928 RVA: 0x002FB468 File Offset: 0x002F9668
				// (set) Token: 0x06002AB1 RID: 10929 RVA: 0x002FB47C File Offset: 0x002F967C
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				public MountCharacteristic Characteristic
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					get
					{
						return (MountCharacteristic)null;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					set
					{
					}
				}

				// Token: 0x170007A0 RID: 1952
				// (get) Token: 0x06002AB2 RID: 10930 RVA: 0x002FB48C File Offset: 0x002F968C
				// (set) Token: 0x06002AB3 RID: 10931 RVA: 0x002FB49C File Offset: 0x002F969C
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				public int IntValue
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					get
					{
						return 0;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					set
					{
					}
				}

				// Token: 0x170007A1 RID: 1953
				// (get) Token: 0x06002AB4 RID: 10932 RVA: 0x002FB4AC File Offset: 0x002F96AC
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				public bool HasIntValue
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					get
					{
						return true;
					}
				}

				// Token: 0x06002AB5 RID: 10933 RVA: 0x002FB4BC File Offset: 0x002F96BC
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void ClearIntValue()
				{
				}

				// Token: 0x06002AB6 RID: 10934 RVA: 0x002FB4CC File Offset: 0x002F96CC
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override bool Equals(object other)
				{
					return true;
				}

				// Token: 0x06002AB7 RID: 10935 RVA: 0x002FB4DC File Offset: 0x002F96DC
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public bool Equals(MountUpdateCharacteristicsEvent.Types.MountCharacteristicUpdate other)
				{
					return true;
				}

				// Token: 0x06002AB8 RID: 10936 RVA: 0x002FB4EC File Offset: 0x002F96EC
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override int GetHashCode()
				{
					return 0;
				}

				// Token: 0x06002AB9 RID: 10937 RVA: 0x002FB4FC File Offset: 0x002F96FC
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override string ToString()
				{
					return null;
				}

				// Token: 0x06002ABA RID: 10938 RVA: 0x002FB50C File Offset: 0x002F970C
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void WriteTo(CodedOutputStream output)
				{
				}

				// Token: 0x06002ABB RID: 10939 RVA: 0x002FB51C File Offset: 0x002F971C
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				void IBufferMessage.InternalWriteTo(ref WriteContext output)
				{
				}

				// Token: 0x06002ABC RID: 10940 RVA: 0x002FB52C File Offset: 0x002F972C
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public int CalculateSize()
				{
					return 0;
				}

				// Token: 0x06002ABD RID: 10941 RVA: 0x002FB53C File Offset: 0x002F973C
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void MergeFrom(MountUpdateCharacteristicsEvent.Types.MountCharacteristicUpdate other)
				{
				}

				// Token: 0x06002ABE RID: 10942 RVA: 0x002FB54C File Offset: 0x002F974C
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void MergeFrom(CodedInputStream input)
				{
				}

				// Token: 0x06002ABF RID: 10943 RVA: 0x002FB55C File Offset: 0x002F975C
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				void IBufferMessage.InternalMergeFrom(ref ParseContext input)
				{
				}

				// Token: 0x06002AC0 RID: 10944 RVA: 0x002FB56C File Offset: 0x002F976C
				[MethodImpl(MethodImplOptions.NoInlining)]
				static MountCharacteristicUpdate()
				{
					uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
					int num = 1;
					for (;;)
					{
						int num2 = num;
						for (;;)
						{
							switch (num2)
							{
							default:
								AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
								num2 = 4;
								break;
							case 1:
								xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
								num2 = 0;
								if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_fc95f38c3f7f4096b9c30dd67655cbfd != 0)
								{
									num2 = 0;
								}
								break;
							case 2:
								goto IL_86;
							case 3:
								return;
							case 4:
								UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
								num2 = 0;
								if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_5750350b4e81418bb3d8d7d0657de68b == 0)
								{
									num2 = 2;
								}
								break;
							case 5:
								MountUpdateCharacteristicsEvent.Types.MountCharacteristicUpdate.IntValueDefaultValue = 0;
								num2 = 3;
								break;
							}
						}
						IL_86:
						MountUpdateCharacteristicsEvent.Types.MountCharacteristicUpdate._parser = new MessageParser<MountUpdateCharacteristicsEvent.Types.MountCharacteristicUpdate>(() => null);
						num = 5;
					}
				}

				// Token: 0x06002AC1 RID: 10945 RVA: 0x002FB650 File Offset: 0x002F9850
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal static bool pTpAdgGYaEPRDB4SSBgv()
				{
					return true;
				}

				// Token: 0x06002AC2 RID: 10946 RVA: 0x002FB658 File Offset: 0x002F9858
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal static MountUpdateCharacteristicsEvent.Types.MountCharacteristicUpdate ppkfPSGY5HhCW4nGhIsQ()
				{
					return null;
				}

				// Token: 0x04000F0C RID: 3852
				private static readonly MessageParser<MountUpdateCharacteristicsEvent.Types.MountCharacteristicUpdate> _parser;

				// Token: 0x04000F0D RID: 3853
				private UnknownFieldSet _unknownFields;

				// Token: 0x04000F0E RID: 3854
				private int _hasBits0;

				// Token: 0x04000F0F RID: 3855
				public const int CharacteristicFieldNumber = 1;

				// Token: 0x04000F10 RID: 3856
				private MountCharacteristic characteristic_;

				// Token: 0x04000F11 RID: 3857
				public const int IntValueFieldNumber = 2;

				// Token: 0x04000F12 RID: 3858
				private static readonly int IntValueDefaultValue;

				// Token: 0x04000F13 RID: 3859
				private int intValue_;

				// Token: 0x04000F14 RID: 3860
				private static MountUpdateCharacteristicsEvent.Types.MountCharacteristicUpdate xDNZIGGY1NWrdmA6jY9e;
			}
		}
	}
}
