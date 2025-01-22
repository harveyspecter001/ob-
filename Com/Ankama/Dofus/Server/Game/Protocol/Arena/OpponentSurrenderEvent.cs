using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Arena
{
	// Token: 0x02000C57 RID: 3159
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class OpponentSurrenderEvent : IMessage<OpponentSurrenderEvent>, IMessage, IEquatable<OpponentSurrenderEvent>, IDeepCloneable<OpponentSurrenderEvent>, IBufferMessage
	{
		// Token: 0x17001C51 RID: 7249
		// (get) Token: 0x060097C4 RID: 38852 RVA: 0x002789B8 File Offset: 0x00276BB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<OpponentSurrenderEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17001C52 RID: 7250
		// (get) Token: 0x060097C5 RID: 38853 RVA: 0x002789C8 File Offset: 0x00276BC8
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

		// Token: 0x17001C53 RID: 7251
		// (get) Token: 0x060097C6 RID: 38854 RVA: 0x002789D8 File Offset: 0x00276BD8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x060097C7 RID: 38855 RVA: 0x002789E8 File Offset: 0x00276BE8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public OpponentSurrenderEvent()
		{
		}

		// Token: 0x060097C8 RID: 38856 RVA: 0x002789F8 File Offset: 0x00276BF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public OpponentSurrenderEvent(OpponentSurrenderEvent other)
		{
		}

		// Token: 0x060097C9 RID: 38857 RVA: 0x00278A08 File Offset: 0x00276C08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public OpponentSurrenderEvent Clone()
		{
			return null;
		}

		// Token: 0x060097CA RID: 38858 RVA: 0x00278A18 File Offset: 0x00276C18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x060097CB RID: 38859 RVA: 0x00278A28 File Offset: 0x00276C28
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(OpponentSurrenderEvent other)
		{
			return true;
		}

		// Token: 0x060097CC RID: 38860 RVA: 0x00278A38 File Offset: 0x00276C38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x060097CD RID: 38861 RVA: 0x00278A48 File Offset: 0x00276C48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x060097CE RID: 38862 RVA: 0x00278A58 File Offset: 0x00276C58
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x060097CF RID: 38863 RVA: 0x00278A68 File Offset: 0x00276C68
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x060097D0 RID: 38864 RVA: 0x00278A78 File Offset: 0x00276C78
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x060097D1 RID: 38865 RVA: 0x00278A88 File Offset: 0x00276C88
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(OpponentSurrenderEvent other)
		{
		}

		// Token: 0x060097D2 RID: 38866 RVA: 0x00278A98 File Offset: 0x00276C98
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x060097D3 RID: 38867 RVA: 0x00278AA8 File Offset: 0x00276CA8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x060097D4 RID: 38868 RVA: 0x00278AB8 File Offset: 0x00276CB8
		[MethodImpl(MethodImplOptions.NoInlining)]
		static OpponentSurrenderEvent()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 4;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 2;
					continue;
				case 2:
					OpponentSurrenderEvent._parser = new MessageParser<OpponentSurrenderEvent>(() => null);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_d0ed3a751ca8432aa19e676130332441 == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 3:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_4ec51c76f8d943f08859e3c2be1f0d41 == 0)
					{
						num2 = 1;
						continue;
					}
					continue;
				case 4:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 3;
					continue;
				}
				break;
			}
		}

		// Token: 0x060097D5 RID: 38869 RVA: 0x00278B84 File Offset: 0x00276D84
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool mG9SG8JNJPXMFMQkZLDX()
		{
			return true;
		}

		// Token: 0x060097D6 RID: 38870 RVA: 0x00278B8C File Offset: 0x00276D8C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static OpponentSurrenderEvent Cl7icTJNGcNl2Qq2uFx8()
		{
			return null;
		}

		// Token: 0x0400385D RID: 14429
		private static readonly MessageParser<OpponentSurrenderEvent> _parser;

		// Token: 0x0400385E RID: 14430
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400385F RID: 14431
		private static OpponentSurrenderEvent w8srlmJNOlRNB6Gsl3DT;
	}
}
