using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Basic
{
	// Token: 0x02000BCA RID: 3018
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class SystemMessageDisplayEvent : IMessage<SystemMessageDisplayEvent>, IMessage, IEquatable<SystemMessageDisplayEvent>, IDeepCloneable<SystemMessageDisplayEvent>, IBufferMessage
	{
		// Token: 0x17001B27 RID: 6951
		// (get) Token: 0x06009142 RID: 37186 RVA: 0x0026F750 File Offset: 0x0026D950
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<SystemMessageDisplayEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17001B28 RID: 6952
		// (get) Token: 0x06009143 RID: 37187 RVA: 0x0026F760 File Offset: 0x0026D960
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17001B29 RID: 6953
		// (get) Token: 0x06009144 RID: 37188 RVA: 0x0026F770 File Offset: 0x0026D970
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

		// Token: 0x06009145 RID: 37189 RVA: 0x0026F780 File Offset: 0x0026D980
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public SystemMessageDisplayEvent()
		{
		}

		// Token: 0x06009146 RID: 37190 RVA: 0x0026F790 File Offset: 0x0026D990
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public SystemMessageDisplayEvent(SystemMessageDisplayEvent other)
		{
		}

		// Token: 0x06009147 RID: 37191 RVA: 0x0026F7A0 File Offset: 0x0026D9A0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public SystemMessageDisplayEvent Clone()
		{
			return null;
		}

		// Token: 0x17001B2A RID: 6954
		// (get) Token: 0x06009148 RID: 37192 RVA: 0x0026F7B0 File Offset: 0x0026D9B0
		// (set) Token: 0x06009149 RID: 37193 RVA: 0x0026F7C0 File Offset: 0x0026D9C0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public bool HangUp
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return true;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x17001B2B RID: 6955
		// (get) Token: 0x0600914A RID: 37194 RVA: 0x0026F7D0 File Offset: 0x0026D9D0
		// (set) Token: 0x0600914B RID: 37195 RVA: 0x0026F7E0 File Offset: 0x0026D9E0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public int MessageId
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

		// Token: 0x17001B2C RID: 6956
		// (get) Token: 0x0600914C RID: 37196 RVA: 0x0026F7F0 File Offset: 0x0026D9F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<string> Parameters
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x0600914D RID: 37197 RVA: 0x0026F800 File Offset: 0x0026DA00
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x0600914E RID: 37198 RVA: 0x0026F810 File Offset: 0x0026DA10
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(SystemMessageDisplayEvent other)
		{
			return true;
		}

		// Token: 0x0600914F RID: 37199 RVA: 0x0026F820 File Offset: 0x0026DA20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06009150 RID: 37200 RVA: 0x0026F830 File Offset: 0x0026DA30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06009151 RID: 37201 RVA: 0x0026F840 File Offset: 0x0026DA40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06009152 RID: 37202 RVA: 0x0026F850 File Offset: 0x0026DA50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06009153 RID: 37203 RVA: 0x0026F860 File Offset: 0x0026DA60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06009154 RID: 37204 RVA: 0x0026F870 File Offset: 0x0026DA70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(SystemMessageDisplayEvent other)
		{
		}

		// Token: 0x06009155 RID: 37205 RVA: 0x0026F880 File Offset: 0x0026DA80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06009156 RID: 37206 RVA: 0x0026F890 File Offset: 0x0026DA90
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06009157 RID: 37207 RVA: 0x0026F8A0 File Offset: 0x0026DAA0
		[MethodImpl(MethodImplOptions.NoInlining)]
		static SystemMessageDisplayEvent()
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
					case 1:
						xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
						num2 = 0;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_3e220445ad264b8fac4b36b1feaab002 == 0)
						{
							num2 = 0;
							continue;
						}
						continue;
					case 2:
						UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
						num2 = 1;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_47f1b3c36e024d4bb84ccbe58986ef1e == 0)
						{
							num2 = 3;
							continue;
						}
						continue;
					case 3:
						goto IL_A7;
					case 4:
						SystemMessageDisplayEvent._repeated_parameters_codec = UhvKwdMSigIudSGM6ge.XVInXhlssT(26U, UhvKwdMSigIudSGM6ge.BvYMM58cmD);
						num2 = 5;
						continue;
					case 5:
						return;
					}
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 2;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_edad103d99794972a048278f53152048 != 0)
					{
						num2 = 1;
					}
				}
				IL_A7:
				SystemMessageDisplayEvent._parser = new MessageParser<SystemMessageDisplayEvent>(() => null);
				num = 4;
			}
		}

		// Token: 0x06009158 RID: 37208 RVA: 0x0026F9A4 File Offset: 0x0026DBA4
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool dNTOoDJ2Qt70KS3pKKQr()
		{
			return true;
		}

		// Token: 0x06009159 RID: 37209 RVA: 0x0026F9AC File Offset: 0x0026DBAC
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static SystemMessageDisplayEvent fhjc2tJ27m2fxWwoiwPR()
		{
			return null;
		}

		// Token: 0x04003606 RID: 13830
		private static readonly MessageParser<SystemMessageDisplayEvent> _parser;

		// Token: 0x04003607 RID: 13831
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003608 RID: 13832
		public const int HangUpFieldNumber = 1;

		// Token: 0x04003609 RID: 13833
		private bool hangUp_;

		// Token: 0x0400360A RID: 13834
		public const int MessageIdFieldNumber = 2;

		// Token: 0x0400360B RID: 13835
		private int messageId_;

		// Token: 0x0400360C RID: 13836
		public const int ParametersFieldNumber = 3;

		// Token: 0x0400360D RID: 13837
		private static readonly FieldCodec<string> _repeated_parameters_codec;

		// Token: 0x0400360E RID: 13838
		private readonly RepeatedField<string> parameters_;

		// Token: 0x0400360F RID: 13839
		private static SystemMessageDisplayEvent MDc17eJ2wTpsOZFNEfP4;
	}
}
