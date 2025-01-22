using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Connection.Protocol
{
	// Token: 0x02000DF5 RID: 3573
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class LoginMessage : IMessage<LoginMessage>, IMessage, IEquatable<LoginMessage>, IDeepCloneable<LoginMessage>, IBufferMessage
	{
		// Token: 0x17001FD8 RID: 8152
		// (get) Token: 0x0600ABFB RID: 44027 RVA: 0x0029DE1C File Offset: 0x0029C01C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<LoginMessage> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17001FD9 RID: 8153
		// (get) Token: 0x0600ABFC RID: 44028 RVA: 0x0029DE2C File Offset: 0x0029C02C
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

		// Token: 0x17001FDA RID: 8154
		// (get) Token: 0x0600ABFD RID: 44029 RVA: 0x0029DE3C File Offset: 0x0029C03C
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

		// Token: 0x0600ABFE RID: 44030 RVA: 0x0029DE4C File Offset: 0x0029C04C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public LoginMessage()
		{
		}

		// Token: 0x0600ABFF RID: 44031 RVA: 0x0029DE5C File Offset: 0x0029C05C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public LoginMessage(LoginMessage other)
		{
		}

		// Token: 0x0600AC00 RID: 44032 RVA: 0x0029DE6C File Offset: 0x0029C06C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public LoginMessage Clone()
		{
			return null;
		}

		// Token: 0x17001FDB RID: 8155
		// (get) Token: 0x0600AC01 RID: 44033 RVA: 0x0029DE7C File Offset: 0x0029C07C
		// (set) Token: 0x0600AC02 RID: 44034 RVA: 0x0029DE8C File Offset: 0x0029C08C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public Request Request
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

		// Token: 0x17001FDC RID: 8156
		// (get) Token: 0x0600AC03 RID: 44035 RVA: 0x0029DE9C File Offset: 0x0029C09C
		// (set) Token: 0x0600AC04 RID: 44036 RVA: 0x0029DEAC File Offset: 0x0029C0AC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public Response Response
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

		// Token: 0x17001FDD RID: 8157
		// (get) Token: 0x0600AC05 RID: 44037 RVA: 0x0029DEBC File Offset: 0x0029C0BC
		// (set) Token: 0x0600AC06 RID: 44038 RVA: 0x0029DECC File Offset: 0x0029C0CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public Event Event
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

		// Token: 0x17001FDE RID: 8158
		// (get) Token: 0x0600AC07 RID: 44039 RVA: 0x0029DEDC File Offset: 0x0029C0DC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public LoginMessage.ContentOneofCase ContentCase
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return (LoginMessage.ContentOneofCase)null;
			}
		}

		// Token: 0x0600AC08 RID: 44040 RVA: 0x0029DEF0 File Offset: 0x0029C0F0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ClearContent()
		{
		}

		// Token: 0x0600AC09 RID: 44041 RVA: 0x0029DF00 File Offset: 0x0029C100
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x0600AC0A RID: 44042 RVA: 0x0029DF10 File Offset: 0x0029C110
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(LoginMessage other)
		{
			return true;
		}

		// Token: 0x0600AC0B RID: 44043 RVA: 0x0029DF20 File Offset: 0x0029C120
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x0600AC0C RID: 44044 RVA: 0x0029DF30 File Offset: 0x0029C130
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x0600AC0D RID: 44045 RVA: 0x0029DF40 File Offset: 0x0029C140
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x0600AC0E RID: 44046 RVA: 0x0029DF50 File Offset: 0x0029C150
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x0600AC0F RID: 44047 RVA: 0x0029DF60 File Offset: 0x0029C160
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x0600AC10 RID: 44048 RVA: 0x0029DF70 File Offset: 0x0029C170
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(LoginMessage other)
		{
		}

		// Token: 0x0600AC11 RID: 44049 RVA: 0x0029DF80 File Offset: 0x0029C180
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x0600AC12 RID: 44050 RVA: 0x0029DF90 File Offset: 0x0029C190
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x0600AC13 RID: 44051 RVA: 0x0029DFA0 File Offset: 0x0029C1A0
		[MethodImpl(MethodImplOptions.NoInlining)]
		static LoginMessage()
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
						AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
						num2 = 4;
						continue;
					case 3:
						goto IL_35;
					case 4:
						UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
						num2 = 0;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_08862c9eab7444c19558a8b548142851 != 0)
						{
							num2 = 0;
							continue;
						}
						continue;
					}
					LoginMessage._parser = new MessageParser<LoginMessage>(() => null);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_8793adccb59548138145e36aa64d0b4b == 0)
					{
						num2 = 1;
					}
				}
				IL_35:
				xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
				num = 2;
			}
		}

		// Token: 0x0600AC14 RID: 44052 RVA: 0x0029E070 File Offset: 0x0029C270
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool IccF3rJUjJDs8cocWKUC()
		{
			return true;
		}

		// Token: 0x0600AC15 RID: 44053 RVA: 0x0029E078 File Offset: 0x0029C278
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static LoginMessage TXdGAvJUKZFR16xDq2I0()
		{
			return null;
		}

		// Token: 0x04003F21 RID: 16161
		private static readonly MessageParser<LoginMessage> _parser;

		// Token: 0x04003F22 RID: 16162
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003F23 RID: 16163
		public const int RequestFieldNumber = 1;

		// Token: 0x04003F24 RID: 16164
		public const int ResponseFieldNumber = 2;

		// Token: 0x04003F25 RID: 16165
		public const int EventFieldNumber = 3;

		// Token: 0x04003F26 RID: 16166
		private object content_;

		// Token: 0x04003F27 RID: 16167
		private LoginMessage.ContentOneofCase contentCase_;

		// Token: 0x04003F28 RID: 16168
		private static LoginMessage XMQZHQJU430SUb10JdMZ;

		// Token: 0x02000DF6 RID: 3574
		public enum ContentOneofCase
		{
			// Token: 0x04003F2A RID: 16170
			None,
			// Token: 0x04003F2B RID: 16171
			Request,
			// Token: 0x04003F2C RID: 16172
			Response,
			// Token: 0x04003F2D RID: 16173
			Event
		}
	}
}
