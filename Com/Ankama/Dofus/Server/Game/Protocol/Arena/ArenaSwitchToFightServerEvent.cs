using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Arena
{
	// Token: 0x02000C22 RID: 3106
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ArenaSwitchToFightServerEvent : IMessage<ArenaSwitchToFightServerEvent>, IMessage, IEquatable<ArenaSwitchToFightServerEvent>, IDeepCloneable<ArenaSwitchToFightServerEvent>, IBufferMessage
	{
		// Token: 0x17001BE3 RID: 7139
		// (get) Token: 0x06009538 RID: 38200 RVA: 0x00276D24 File Offset: 0x00274F24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ArenaSwitchToFightServerEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17001BE4 RID: 7140
		// (get) Token: 0x06009539 RID: 38201 RVA: 0x00276D34 File Offset: 0x00274F34
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

		// Token: 0x17001BE5 RID: 7141
		// (get) Token: 0x0600953A RID: 38202 RVA: 0x00276D44 File Offset: 0x00274F44
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

		// Token: 0x0600953B RID: 38203 RVA: 0x00276D54 File Offset: 0x00274F54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ArenaSwitchToFightServerEvent()
		{
		}

		// Token: 0x0600953C RID: 38204 RVA: 0x00276D64 File Offset: 0x00274F64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ArenaSwitchToFightServerEvent(ArenaSwitchToFightServerEvent other)
		{
		}

		// Token: 0x0600953D RID: 38205 RVA: 0x00276D74 File Offset: 0x00274F74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ArenaSwitchToFightServerEvent Clone()
		{
			return null;
		}

		// Token: 0x17001BE6 RID: 7142
		// (get) Token: 0x0600953E RID: 38206 RVA: 0x00276D84 File Offset: 0x00274F84
		// (set) Token: 0x0600953F RID: 38207 RVA: 0x00276D94 File Offset: 0x00274F94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string Address
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x17001BE7 RID: 7143
		// (get) Token: 0x06009540 RID: 38208 RVA: 0x00276DA4 File Offset: 0x00274FA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> Ports
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17001BE8 RID: 7144
		// (get) Token: 0x06009541 RID: 38209 RVA: 0x00276DB4 File Offset: 0x00274FB4
		// (set) Token: 0x06009542 RID: 38210 RVA: 0x00276DC4 File Offset: 0x00274FC4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public string Token
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x06009543 RID: 38211 RVA: 0x00276DD4 File Offset: 0x00274FD4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06009544 RID: 38212 RVA: 0x00276DE4 File Offset: 0x00274FE4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(ArenaSwitchToFightServerEvent other)
		{
			return true;
		}

		// Token: 0x06009545 RID: 38213 RVA: 0x00276DF4 File Offset: 0x00274FF4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06009546 RID: 38214 RVA: 0x00276E04 File Offset: 0x00275004
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06009547 RID: 38215 RVA: 0x00276E14 File Offset: 0x00275014
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06009548 RID: 38216 RVA: 0x00276E24 File Offset: 0x00275024
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06009549 RID: 38217 RVA: 0x00276E34 File Offset: 0x00275034
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x0600954A RID: 38218 RVA: 0x00276E44 File Offset: 0x00275044
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(ArenaSwitchToFightServerEvent other)
		{
		}

		// Token: 0x0600954B RID: 38219 RVA: 0x00276E54 File Offset: 0x00275054
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x0600954C RID: 38220 RVA: 0x00276E64 File Offset: 0x00275064
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x0600954D RID: 38221 RVA: 0x00276E74 File Offset: 0x00275074
		[MethodImpl(MethodImplOptions.NoInlining)]
		static ArenaSwitchToFightServerEvent()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 4;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					ArenaSwitchToFightServerEvent._parser = new MessageParser<ArenaSwitchToFightServerEvent>(() => null);
					num2 = 5;
					continue;
				case 2:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_8793adccb59548138145e36aa64d0b4b == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 3:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 2;
					continue;
				case 4:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 3;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_0cf81502393c4abba92bedafaef205c1 == 0)
					{
						num2 = 3;
						continue;
					}
					continue;
				case 5:
					ArenaSwitchToFightServerEvent._repeated_ports_codec = M86nYSs6HwlxZ95MMuN.XVInXhlssT(18U, M86nYSs6HwlxZ95MMuN.odfsLRrd4X);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_cfc3d3d0de31471dab715ade277efc6c == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				}
				break;
			}
		}

		// Token: 0x0600954E RID: 38222 RVA: 0x00276F74 File Offset: 0x00275174
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool Pq8F6CJX5EJgAaPr4uG8()
		{
			return true;
		}

		// Token: 0x0600954F RID: 38223 RVA: 0x00276F7C File Offset: 0x0027517C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static ArenaSwitchToFightServerEvent SbcKnYJXyOWDWTuNpvJj()
		{
			return null;
		}

		// Token: 0x04003792 RID: 14226
		private static readonly MessageParser<ArenaSwitchToFightServerEvent> _parser;

		// Token: 0x04003793 RID: 14227
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003794 RID: 14228
		public const int AddressFieldNumber = 1;

		// Token: 0x04003795 RID: 14229
		private string address_;

		// Token: 0x04003796 RID: 14230
		public const int PortsFieldNumber = 2;

		// Token: 0x04003797 RID: 14231
		private static readonly FieldCodec<int> _repeated_ports_codec;

		// Token: 0x04003798 RID: 14232
		private readonly RepeatedField<int> ports_;

		// Token: 0x04003799 RID: 14233
		public const int TokenFieldNumber = 3;

		// Token: 0x0400379A RID: 14234
		private string token_;

		// Token: 0x0400379B RID: 14235
		internal static ArenaSwitchToFightServerEvent jys6ygJXaIoocF6Ild1R;
	}
}
