using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Spell
{
	// Token: 0x02000116 RID: 278
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ForgettableSpellActionRequest : IMessage<ForgettableSpellActionRequest>, IMessage, IEquatable<ForgettableSpellActionRequest>, IDeepCloneable<ForgettableSpellActionRequest>, IBufferMessage
	{
		// Token: 0x17000231 RID: 561
		// (get) Token: 0x06000CB0 RID: 3248 RVA: 0x00198660 File Offset: 0x00196860
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ForgettableSpellActionRequest> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17000232 RID: 562
		// (get) Token: 0x06000CB1 RID: 3249 RVA: 0x00198670 File Offset: 0x00196870
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

		// Token: 0x17000233 RID: 563
		// (get) Token: 0x06000CB2 RID: 3250 RVA: 0x00198680 File Offset: 0x00196880
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

		// Token: 0x06000CB3 RID: 3251 RVA: 0x00198690 File Offset: 0x00196890
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ForgettableSpellActionRequest()
		{
		}

		// Token: 0x06000CB4 RID: 3252 RVA: 0x001986A0 File Offset: 0x001968A0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ForgettableSpellActionRequest(ForgettableSpellActionRequest other)
		{
		}

		// Token: 0x06000CB5 RID: 3253 RVA: 0x001986B0 File Offset: 0x001968B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ForgettableSpellActionRequest Clone()
		{
			return null;
		}

		// Token: 0x17000234 RID: 564
		// (get) Token: 0x06000CB6 RID: 3254 RVA: 0x001986C0 File Offset: 0x001968C0
		// (set) Token: 0x06000CB7 RID: 3255 RVA: 0x001986D0 File Offset: 0x001968D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int SpellId
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

		// Token: 0x17000235 RID: 565
		// (get) Token: 0x06000CB8 RID: 3256 RVA: 0x001986E0 File Offset: 0x001968E0
		// (set) Token: 0x06000CB9 RID: 3257 RVA: 0x001986F4 File Offset: 0x001968F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ForgettableSpellActionRequest.Types.ForgettableSpellAction Action
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return (ForgettableSpellActionRequest.Types.ForgettableSpellAction)null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x06000CBA RID: 3258 RVA: 0x00198704 File Offset: 0x00196904
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06000CBB RID: 3259 RVA: 0x00198714 File Offset: 0x00196914
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(ForgettableSpellActionRequest other)
		{
			return true;
		}

		// Token: 0x06000CBC RID: 3260 RVA: 0x00198724 File Offset: 0x00196924
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06000CBD RID: 3261 RVA: 0x00198734 File Offset: 0x00196934
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06000CBE RID: 3262 RVA: 0x00198744 File Offset: 0x00196944
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06000CBF RID: 3263 RVA: 0x00198754 File Offset: 0x00196954
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06000CC0 RID: 3264 RVA: 0x00198764 File Offset: 0x00196964
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06000CC1 RID: 3265 RVA: 0x00198774 File Offset: 0x00196974
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(ForgettableSpellActionRequest other)
		{
		}

		// Token: 0x06000CC2 RID: 3266 RVA: 0x00198784 File Offset: 0x00196984
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06000CC3 RID: 3267 RVA: 0x00198794 File Offset: 0x00196994
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06000CC4 RID: 3268 RVA: 0x001987A4 File Offset: 0x001969A4
		[MethodImpl(MethodImplOptions.NoInlining)]
		static ForgettableSpellActionRequest()
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
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_fa7a94a3a5d141b3832a6c259d02e750 == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 2:
					return;
				case 3:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_b83b2acd599549429d401345bd5187dd == 0)
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
				ForgettableSpellActionRequest._parser = new MessageParser<ForgettableSpellActionRequest>(() => null);
				num2 = 2;
			}
		}

		// Token: 0x06000CC5 RID: 3269 RVA: 0x00198870 File Offset: 0x00196A70
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool VdxFFJOcNlsuK4G6FbpU()
		{
			return true;
		}

		// Token: 0x06000CC6 RID: 3270 RVA: 0x00198878 File Offset: 0x00196A78
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static ForgettableSpellActionRequest RI6PbeOcx6R68mjdXk9V()
		{
			return null;
		}

		// Token: 0x04000498 RID: 1176
		private static readonly MessageParser<ForgettableSpellActionRequest> _parser;

		// Token: 0x04000499 RID: 1177
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400049A RID: 1178
		public const int SpellIdFieldNumber = 1;

		// Token: 0x0400049B RID: 1179
		private int spellId_;

		// Token: 0x0400049C RID: 1180
		public const int ActionFieldNumber = 2;

		// Token: 0x0400049D RID: 1181
		private ForgettableSpellActionRequest.Types.ForgettableSpellAction action_;

		// Token: 0x0400049E RID: 1182
		internal static ForgettableSpellActionRequest Ndbu9EOcXsZrEI2rx7sr;

		// Token: 0x02000117 RID: 279
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static class Types
		{
			// Token: 0x06000CC7 RID: 3271 RVA: 0x002AB574 File Offset: 0x002A9774
			[MethodImpl(MethodImplOptions.NoInlining)]
			static Types()
			{
				uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
				xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
			}

			// Token: 0x02000118 RID: 280
			public enum ForgettableSpellAction
			{
				// Token: 0x040004A0 RID: 1184
				[OriginalName("FORGET")]
				Forget,
				// Token: 0x040004A1 RID: 1185
				[OriginalName("EQUIP")]
				Equip,
				// Token: 0x040004A2 RID: 1186
				[OriginalName("REMOVE")]
				Remove
			}
		}
	}
}
