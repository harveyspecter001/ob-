using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Cosmetic
{
	// Token: 0x02000C63 RID: 3171
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class CharacterAppearanceCollectionEvent : IMessage<CharacterAppearanceCollectionEvent>, IMessage, IEquatable<CharacterAppearanceCollectionEvent>, IDeepCloneable<CharacterAppearanceCollectionEvent>, IBufferMessage
	{
		// Token: 0x17001C66 RID: 7270
		// (get) Token: 0x0600984B RID: 38987 RVA: 0x0027AC14 File Offset: 0x00278E14
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<CharacterAppearanceCollectionEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17001C67 RID: 7271
		// (get) Token: 0x0600984C RID: 38988 RVA: 0x0027AC24 File Offset: 0x00278E24
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

		// Token: 0x17001C68 RID: 7272
		// (get) Token: 0x0600984D RID: 38989 RVA: 0x0027AC34 File Offset: 0x00278E34
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

		// Token: 0x0600984E RID: 38990 RVA: 0x0027AC44 File Offset: 0x00278E44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public CharacterAppearanceCollectionEvent()
		{
		}

		// Token: 0x0600984F RID: 38991 RVA: 0x0027AC54 File Offset: 0x00278E54
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public CharacterAppearanceCollectionEvent(CharacterAppearanceCollectionEvent other)
		{
		}

		// Token: 0x06009850 RID: 38992 RVA: 0x0027AC64 File Offset: 0x00278E64
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public CharacterAppearanceCollectionEvent Clone()
		{
			return null;
		}

		// Token: 0x17001C69 RID: 7273
		// (get) Token: 0x06009851 RID: 38993 RVA: 0x0027AC74 File Offset: 0x00278E74
		// (set) Token: 0x06009852 RID: 38994 RVA: 0x0027AC84 File Offset: 0x00278E84
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public CharacterFaces CharacterFaces
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

		// Token: 0x17001C6A RID: 7274
		// (get) Token: 0x06009853 RID: 38995 RVA: 0x0027AC94 File Offset: 0x00278E94
		// (set) Token: 0x06009854 RID: 38996 RVA: 0x0027ACA4 File Offset: 0x00278EA4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public CharacterColors CharacterColors
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

		// Token: 0x06009855 RID: 38997 RVA: 0x0027ACB4 File Offset: 0x00278EB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06009856 RID: 38998 RVA: 0x0027ACC4 File Offset: 0x00278EC4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(CharacterAppearanceCollectionEvent other)
		{
			return true;
		}

		// Token: 0x06009857 RID: 38999 RVA: 0x0027ACD4 File Offset: 0x00278ED4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06009858 RID: 39000 RVA: 0x0027ACE4 File Offset: 0x00278EE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06009859 RID: 39001 RVA: 0x0027ACF4 File Offset: 0x00278EF4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x0600985A RID: 39002 RVA: 0x0027AD04 File Offset: 0x00278F04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x0600985B RID: 39003 RVA: 0x0027AD14 File Offset: 0x00278F14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x0600985C RID: 39004 RVA: 0x0027AD24 File Offset: 0x00278F24
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CharacterAppearanceCollectionEvent other)
		{
		}

		// Token: 0x0600985D RID: 39005 RVA: 0x0027AD34 File Offset: 0x00278F34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x0600985E RID: 39006 RVA: 0x0027AD44 File Offset: 0x00278F44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x0600985F RID: 39007 RVA: 0x0027AD54 File Offset: 0x00278F54
		[MethodImpl(MethodImplOptions.NoInlining)]
		static CharacterAppearanceCollectionEvent()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 4;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					CharacterAppearanceCollectionEvent._parser = new MessageParser<CharacterAppearanceCollectionEvent>(() => null);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_489c2019c8d9417e8d3b3ace7245e128 == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 2:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_21f9c0f687924238a6a5f1548cc32497 != 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 3:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 2;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_5031fac8c16a43b8b5e515682df08cbd == 0)
					{
						num2 = 0;
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

		// Token: 0x06009860 RID: 39008 RVA: 0x0027AE38 File Offset: 0x00279038
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool K3ALRDJN1DJ5NyxbfUgn()
		{
			return true;
		}

		// Token: 0x06009861 RID: 39009 RVA: 0x0027AE40 File Offset: 0x00279040
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static CharacterAppearanceCollectionEvent V2MAFnJNa8udIXkofVmx()
		{
			return null;
		}

		// Token: 0x04003883 RID: 14467
		private static readonly MessageParser<CharacterAppearanceCollectionEvent> _parser;

		// Token: 0x04003884 RID: 14468
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003885 RID: 14469
		public const int CharacterFacesFieldNumber = 1;

		// Token: 0x04003886 RID: 14470
		private CharacterFaces characterFaces_;

		// Token: 0x04003887 RID: 14471
		public const int CharacterColorsFieldNumber = 2;

		// Token: 0x04003888 RID: 14472
		private CharacterColors characterColors_;

		// Token: 0x04003889 RID: 14473
		internal static CharacterAppearanceCollectionEvent Ofb4csJNorqYAhKG1b8s;
	}
}
