using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Basic
{
	// Token: 0x02000BD8 RID: 3032
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class SequenceNumberEvent : IMessage<SequenceNumberEvent>, IMessage, IEquatable<SequenceNumberEvent>, IDeepCloneable<SequenceNumberEvent>, IBufferMessage
	{
		// Token: 0x17001B4F RID: 6991
		// (get) Token: 0x060091FD RID: 37373 RVA: 0x002705E0 File Offset: 0x0026E7E0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<SequenceNumberEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17001B50 RID: 6992
		// (get) Token: 0x060091FE RID: 37374 RVA: 0x002705F0 File Offset: 0x0026E7F0
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

		// Token: 0x17001B51 RID: 6993
		// (get) Token: 0x060091FF RID: 37375 RVA: 0x00270600 File Offset: 0x0026E800
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

		// Token: 0x06009200 RID: 37376 RVA: 0x00270610 File Offset: 0x0026E810
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public SequenceNumberEvent()
		{
		}

		// Token: 0x06009201 RID: 37377 RVA: 0x00270620 File Offset: 0x0026E820
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public SequenceNumberEvent(SequenceNumberEvent other)
		{
		}

		// Token: 0x06009202 RID: 37378 RVA: 0x00270630 File Offset: 0x0026E830
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public SequenceNumberEvent Clone()
		{
			return null;
		}

		// Token: 0x06009203 RID: 37379 RVA: 0x00270640 File Offset: 0x0026E840
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06009204 RID: 37380 RVA: 0x00270650 File Offset: 0x0026E850
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(SequenceNumberEvent other)
		{
			return true;
		}

		// Token: 0x06009205 RID: 37381 RVA: 0x00270660 File Offset: 0x0026E860
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06009206 RID: 37382 RVA: 0x00270670 File Offset: 0x0026E870
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06009207 RID: 37383 RVA: 0x00270680 File Offset: 0x0026E880
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06009208 RID: 37384 RVA: 0x00270690 File Offset: 0x0026E890
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06009209 RID: 37385 RVA: 0x002706A0 File Offset: 0x0026E8A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x0600920A RID: 37386 RVA: 0x002706B0 File Offset: 0x0026E8B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(SequenceNumberEvent other)
		{
		}

		// Token: 0x0600920B RID: 37387 RVA: 0x002706C0 File Offset: 0x0026E8C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x0600920C RID: 37388 RVA: 0x002706D0 File Offset: 0x0026E8D0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x0600920D RID: 37389 RVA: 0x002706E0 File Offset: 0x0026E8E0
		[MethodImpl(MethodImplOptions.NoInlining)]
		static SequenceNumberEvent()
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
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_b79252eba1e243578ef10b6ab35a1392 == 0)
						{
							num2 = 0;
							continue;
						}
						continue;
					case 2:
						goto IL_87;
					case 3:
						return;
					case 4:
						UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
						num2 = 2;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_f57ce5f5a75c4f899b90ad8e56b209a8 != 0)
						{
							num2 = 1;
							continue;
						}
						continue;
					}
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 3;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_c1eba4e0b34b449ab7fc8da6d2bce1f2 == 0)
					{
						num2 = 4;
					}
				}
				IL_87:
				SequenceNumberEvent._parser = new MessageParser<SequenceNumberEvent>(() => null);
				num = 3;
			}
		}

		// Token: 0x0600920E RID: 37390 RVA: 0x002707C8 File Offset: 0x0026E9C8
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool uqAM7IJEnv6afy6K8ue2()
		{
			return true;
		}

		// Token: 0x0600920F RID: 37391 RVA: 0x002707D0 File Offset: 0x0026E9D0
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static SequenceNumberEvent D2FK8BJEmvWeQHNBRCsu()
		{
			return null;
		}

		// Token: 0x0400365C RID: 13916
		private static readonly MessageParser<SequenceNumberEvent> _parser;

		// Token: 0x0400365D RID: 13917
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400365E RID: 13918
		private static SequenceNumberEvent o10JL8JEfsbKINDkeTSG;
	}
}
